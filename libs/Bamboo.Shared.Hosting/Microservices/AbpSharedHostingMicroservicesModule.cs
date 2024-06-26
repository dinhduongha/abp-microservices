using System.Text.Json.Serialization;
using Medallion.Threading;
using Medallion.Threading.Redis;
using Medallion.Threading.FileSystem;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Extensions.DependencyInjection;

using Hangfire;
using Hangfire.LiteDB;
using StackExchange.Redis;

using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.Swashbuckle;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.BackgroundJobs.RabbitMQ;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.BackgroundWorkers.Hangfire;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.EventBus.Rebus;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Timing;

//using AbpShared.Hosting.AspNetCore;

[DependsOn(
	typeof(AbpAutofacModule),
    typeof(AbpDataModule),
	typeof(AbpCachingStackExchangeRedisModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpDistributedLockingModule),
    typeof(AbpSwashbuckleModule),
    //typeof(AbpEventBusRebusModule),
    //typeof(AbpEventBusRabbitMqModule),
    //typeof(AbpBackgroundJobsRabbitMqModule),
    //typeof(AbpSharedHostingAspNetCoreModule),
	typeof(AbpEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCorePostgreSqlModule)
)]
public class AbpSharedHostingMicroservicesModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    	// https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();
        Configure<JsonOptions>(jsonOptions =>
        {
            jsonOptions.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            //jsonOptions.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        });
        Configure<AbpDbContextOptions>(options =>
        {
            options.UseNpgsql();
        });

        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = true;
        });

        Configure<AbpClockOptions>(options => options.Kind = DateTimeKind.Utc);

        ConfigureCache(context, configuration);
        ConfigureRedis(context, configuration);
        ConfigureDataProtection(context, configuration, hostingEnvironment);
        ConfigureDistributedLocking(context, configuration);
        ConfigureHangfire(context, configuration);
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
        //var hostingEnvironment = context.Services.GetHostingEnvironment();
        //if (!hostingEnvironment.IsDevelopment())
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
            else
            {
                dataProtectionBuilder.PersistKeysToFileSystem(new DirectoryInfo($".{appName}-bamboo.Protection-Keys"));
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

    private void ConfigureDistributedLocking(
            ServiceConfigurationContext context,
            IConfiguration configuration)
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
            var connection = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]!);
            return new RedisDistributedSynchronizationProvider(connection.GetDatabase());
        });
    }

    private void ConfigureHangfire(ServiceConfigurationContext context, IConfiguration configuration)
    {
        context.Services.AddHangfire(config =>
        {
            config.UseLiteDbStorage("./hf.db");
        });
    }
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        //app.UseHttpMethodOverride();
        //app.UseForwardedHeaders();
        //app.UseHttpLogging();

        app.Use((context, next) =>
        {
            var xproto = context.Request.Headers["X-Forwarded-Proto"].ToString();
            if (xproto != null && xproto.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                context.Request.Scheme = "https";
            }
            return next();
        });

        //app.UseAbpHangfireDashboard(); //should add to the request pipeline before the app.UseConfiguredEndpoints()
        //app.UseConfiguredEndpoints();
        //await context.AddBackgroundWorkerAsync<MyLogWorker>();

        // app.UseSwagger(options =>
        // {
        //     //options.RouteTemplate = "api/v1/myname/swagger/{documentName}/swagger.json";
        // });

        // app.UseAbpSwaggerUI(options =>
        // {
        //     options.SwaggerEndpoint("/swagger/v1/swagger.json", "Support APP API");

        //     //options.SwaggerEndpoint("/api/v1/myname/swagger/v1/swagger.json", "Support APP API");
        //     //options.RoutePrefix = "api/v1/myname";
        //     //options.InjectJavascript("/swagger/ui/abp.js");
        //     //options.InjectJavascript("/swagger/ui/abp.swagger.js");

        //     var configuration = context.GetConfiguration();
        //     options.OAuthClientId(configuration["AuthServer:SwaggerClientId"]);
        //     options.OAuthScopes("Starify");
        // });


    }
}