using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Volo.Abp.Guids;
using Volo.Abp.Uow;
using Volo.Abp.Modularity;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Bamboo.Admin.EntityFrameworkCore;

[DependsOn(
    typeof(AbpEntityFrameworkCorePostgreSqlModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),    
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(BlobStoringDatabaseEntityFrameworkCoreModule)
    )]
public class AdminExtEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        // https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        AdminEfCoreEntityExtensionMappings.ConfigureExtraProperties();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {

        context.Services.AddAbpDbContext<AdminDbContext>(options =>
        {
            
            //options.ReplaceDbContext<IFeatureManagementDbContext>();
            //options.ReplaceDbContext<IPermissionManagementDbContext>();
            //options.ReplaceDbContext<ISettingManagementDbContext>();            
            //options.ReplaceDbContext<IIdentityDbContext>();
            //options.ReplaceDbContext<IOpenIddictDbContext>();
            //options.ReplaceDbContext<ITenantManagementDbContext>();
            //options.ReplaceDbContext<IAuditLoggingDbContext>();
            //options.ReplaceDbContext<IBackgroundJobsDbContext>();
            //options.ReplaceDbContext<IBlobStoringDbContext>();

            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
            * See also BambooMigrationsDbContextFactory for EF Core tooling. 
            */
            //options.UseNpgsql();
            //options.UseNpgsql(configuration.GetConnectionString("Admin"));
            //options.UseNpgsql(configuration.GetConnectionString(AdminDbProperties.ConnectionStringName));
            
        });
        Configure<AbpSequentialGuidGeneratorOptions>(options =>
        {
            options.DefaultSequentialGuidType = SequentialGuidType.SequentialAsString;
        });
        context.Services.Replace(ServiceDescriptor.Transient<IGuidGenerator, MySequentialGuidGenerator>());
    }
}
