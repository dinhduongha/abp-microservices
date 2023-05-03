using System.Net;

using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.HttpOverrides;

using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration;

using Medallion.Threading;
using Medallion.Threading.Redis;
using Medallion.Threading.FileSystem;
using StackExchange.Redis;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Twilio;

using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp.Sms;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.Account.Settings;
using Volo.Abp.SettingManagement;
using Volo.Abp.Settings;

using Bamboo.Abp.VerificationCode;

namespace Bamboo.Authentication;
[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpSmsModule))]
public class BambooAuthenticationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        context.Services.AddHttpClient();

        context.Services.TryAddTransient<IVerificationCodeGenerator, VerificationCodeGenerator>();
        context.Services.TryAddTransient<IVerificationCodeManager, VerificationCodeManager>();
        //ConfigureFirebase(context, configuration);
        //ConfigureTwilio(context, configuration);

        context.Services.Configure<AbpAspNetCoreMultiTenancyOptions>(options =>
        {
            options.TenantKey = configuration["App:TenantKey"] ?? "tenant";
        });

        ConfigureCache(context, configuration);
        ConfigureRedis(context, configuration);
        ConfigureDistributedLock(context, configuration);
        ConfigureDataProtection(context, configuration);
    }

    private void ConfigureFirebase(ServiceConfigurationContext context, IConfiguration configuration)
    {
        FirebaseApp.Create(new AppOptions()
        {
            //export GOOGLE_APPLICATION_CREDENTIALS
            //Credential = GoogleCredential.GetApplicationDefault(),
            Credential = GoogleCredential.FromFile("firebase-adminsdk.json"),
        }); ;
    }

    private void ConfigureTwilio(ServiceConfigurationContext context, IConfiguration configuration)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = configuration["Twilio:AccountSID"];
        string authToken = configuration["Twilio:AuthToken"];
        TwilioClient.Init(accountSid, authToken);
    }

    private void ConfigureCache(ServiceConfigurationContext context, IConfiguration configuration)
    {
        //Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "Admin:"; });
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = configuration["App:CacheName"] ?? "Bamboo:"; });

    }

    private void ConfigureRedis(ServiceConfigurationContext context, IConfiguration configuration)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        bool enabledRedis = Convert.ToBoolean(configuration["Redis:IsEnabled"]);

        var redisOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);

        if (enabledRedis)
        {
            redisOptions.User = configuration["Redis:User"];
            redisOptions.Password = configuration["Redis:Password"];
            Configure<RedisCacheOptions>(options =>
            {
                //var configurationOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
                //configurationOptions.User = configuration["Redis:User"];
                //configurationOptions.Password = configuration["Redis:Password"];
                //options.ConfigurationOptions = configurationOptions;
                options.Configuration = configuration["Redis:Configuration"];
                options.ConfigurationOptions = redisOptions;
            });
        }

        //if (!hostingEnvironment.IsDevelopment())
        //if (enabledRedis)
        //{
        //    var redis = ConnectionMultiplexer.Connect(redisOptions);
        //    //var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
        //    var dataProtectionBuilder = context.Services.AddDataProtection().SetApplicationName("Bamboo");
        //    dataProtectionBuilder.PersistKeysToStackExchangeRedis(redis, "Bamboo-Protection-Keys");
        //}

        //context.Services.AddSingleton<IDistributedLockProvider>(sp =>
        //{
        //    //if (hostingEnvironment.IsDevelopment())
        //    if (!enabledRedis)
        //    {
        //        DirectoryInfo lockFileDirectory = new DirectoryInfo($".bamboocache");
        //        return new FileDistributedSynchronizationProvider(lockFileDirectory);
        //    }
        //    else
        //    {
        //        //var redisOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
        //        //redisOptions.User = configuration["Redis:User"];
        //        //redisOptions.Password = configuration["Redis:Password"];
        //        //var connection = ConnectionMultiplexer
        //        //    .Connect(configuration["Redis:Configuration"]);

        //        var connection = ConnectionMultiplexer
        //            .Connect(redisOptions);
        //        return new RedisDistributedSynchronizationProvider(connection.GetDatabase());
        //    }
        //});
    }

    private void ConfigureDistributedLock(ServiceConfigurationContext context, IConfiguration configuration)
    {
        context.Services.AddSingleton<IDistributedLockProvider>(sp =>
        {
            var redisOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
            bool enabledRedis = Convert.ToBoolean(configuration["Redis:IsEnabled"]);
            if (!enabledRedis)
            {
                DirectoryInfo lockFileDirectory = new DirectoryInfo($".bamboocache");
                return new FileDistributedSynchronizationProvider(lockFileDirectory);

            }
            else
            {
                redisOptions.User = configuration["Redis:User"];
                redisOptions.Password = configuration["Redis:Password"];
                var redis = ConnectionMultiplexer.Connect(redisOptions);
                return new RedisDistributedSynchronizationProvider(redis.GetDatabase());
            }
        });
    }

    private void ConfigureDataProtection(ServiceConfigurationContext context, IConfiguration configuration)
    {
        string appName = configuration["App:Name"] ?? "Bamboo";
        //string appName = configuration["ApplicationName"] ?? "Bamboo";
        //string appName = context.Services.GetApplicationName();
        var dataProtectionBuilder = context.Services.AddDataProtection().SetApplicationName($"{appName}");
        {
            var redisOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
            bool enabledRedis = Convert.ToBoolean(configuration["Redis:IsEnabled"]);
            if (enabledRedis)
            {
                redisOptions.User = configuration["Redis:User"];
                redisOptions.Password = configuration["Redis:Password"];
                var redis = ConnectionMultiplexer.Connect(redisOptions);
                dataProtectionBuilder.PersistKeysToStackExchangeRedis(redis, $"{appName}-Protection-Keys");
            }
        }
    }

    private void ConfigureForwardProxy(ServiceConfigurationContext context, IConfiguration configuration)
    {
        context.Services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor
                                       | ForwardedHeaders.XForwardedProto
                                       | ForwardedHeaders.XForwardedHost;
            options.KnownNetworks.Clear();
            options.KnownProxies.Clear();
            options.RequireHeaderSymmetry = false;
        });

        context.Services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.RequestHeaders
                                    //| HttpLoggingFields.RequestPropertiesAndHeaders 
                                    //| HttpLoggingFields.ResponsePropertiesAndHeaders
                                    //| HttpLoggingFields.ResponseHeaders
                                    //| HttpLoggingFields.RequestProtocol
                                    //| HttpLoggingFields.ResponseBody
                                    //| HttpLoggingFields.RequestBody
                                    | HttpLoggingFields.RequestPath;

        });
    }

    public async override Task OnApplicationInitializationAsync(Volo.Abp.ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();
        //GlobalSettingManagementProvider settingManagementProvider = context.ServiceProvider.GetRequiredService<GlobalSettingManagementProvider>();
        //SettingDefinitionManager settingDefinitionManager = context.ServiceProvider.GetRequiredService<SettingDefinitionManager>();
        //await settingManagementProvider.SetAsync(
        //   settingDefinitionManager.Get(AccountSettingNames.IsSelfRegistrationEnabled),
        //   true.ToString(),
        //   GlobalSettingValueProvider.ProviderName
        //);

        //settingManagementProvider.SetAsync(
        //    settingDefinitionManager.Get(IdentitySettingNames.Password.RequireNonAlphanumeric),
        //    false.ToString(),
        //    GlobalSettingValueProvider.ProviderName
        //);

        //settingManagementProvider.SetAsync(
        //    settingDefinitionManager.Get(IdentitySettingNames.Password.RequireUppercase),
        //    false.ToString(),
        //    GlobalSettingValueProvider.ProviderName
        //);

        //app.UseHttpMethodOverride();
        app.UseForwardedHeaders();
        //app.UseHttpLogging();
        
        ///// Always behind ssl proxy
        app.Use((context, next) =>
        {
            var xproto = context.Request.Headers["X-Forwarded-Proto"].ToString();
            if (xproto != null && xproto.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                context.Request.Scheme = "https";
            }
            return next();
        });

        await base.OnApplicationInitializationAsync(context);
    }
}

