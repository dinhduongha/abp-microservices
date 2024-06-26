using System;
using Microsoft.EntityFrameworkCore;

using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Bamboo.Admin.EntityFrameworkCore;

public static class AdminEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void ConfigureExtraProperties()
    {
       // AdminGlobalFeatureConfigurator.Configure();
       // AdminModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
        ObjectExtensionManager.Instance
            .MapEfCoreProperty<IdentityUser, string>(
                "SocialSecurityNumber",
                (entityBuilder, propertyBuilder) =>
                {
                    propertyBuilder.HasMaxLength(32);
                }
            );
        ObjectExtensionManager.Instance
            .MapEfCoreProperty<Tenant, Guid>(
                "ParentId",
                (entityBuilder, propertyBuilder) =>
                {
                    propertyBuilder.HasColumnType("uuid");
                    propertyBuilder.HasColumnName("ParentId");
                }
            );
        ObjectExtensionManager.Instance
            .MapEfCoreProperty<Tenant, Guid>(
                "OwnerId",
                (entityBuilder, propertyBuilder) =>
                {
                    propertyBuilder.HasColumnType("uuid");
                    propertyBuilder.HasColumnName("OwnerId");
                }
            );
        });
    }
    
    public static void ConfigureAdminExt(this ModelBuilder builder)
    {
        //builder.InitPostgreSQLExtension();
        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureBlobStoring();
        //builder.PostgreSQLDataType();
    }
}
