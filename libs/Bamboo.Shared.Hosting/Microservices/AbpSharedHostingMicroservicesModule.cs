using Medallion.Threading;
using Medallion.Threading.Redis;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.BackgroundJobs.RabbitMQ;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
//using AbpShared.Hosting.AspNetCore;

[DependsOn(
    typeof(AbpSharedHostingAspNetCoreModule),
    typeof(AbpBackgroundJobsRabbitMqModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AbpDistributedLockingModule)
)]
public class AbpSharedHostingMicroservicesModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    	// https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var configuration = context.Services.GetConfiguration();

        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = true;
        });

        Configure<AbpDistributedCacheOptions>(options =>
        {
            options.KeyPrefix = "Starify:";
        });

        var redisOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
        bool enabledRedis = Convert.ToBoolean(configuration["Redis:IsEnabled"]);
        redisOptions.User = configuration["Redis:User"];
        redisOptions.Password = configuration["Redis:Password"];

        Configure<RedisCacheOptions>(options =>
        {
            options.Configuration = configuration["Redis:Configuration"];
            //var configurationOptions = ConfigurationOptions.Parse(configuration["Redis:Configuration"]);
            //configurationOptions.User = configuration["Redis:User"];
            //configurationOptions.Password = configuration["Redis:Password"];
            options.ConfigurationOptions = redisOptions;
        });
        
        var redis = ConnectionMultiplexer.Connect(redisOptions);
        context.Services
            .AddDataProtection()
            .PersistKeysToStackExchangeRedis(redis, "Bamboo-Protection-Keys");
            
        context.Services.AddSingleton<IDistributedLockProvider>(sp =>
        {
            var connection = ConnectionMultiplexer.Connect(redisOptions);
            return new RedisDistributedSynchronizationProvider(connection.GetDatabase());
        });
    }
}