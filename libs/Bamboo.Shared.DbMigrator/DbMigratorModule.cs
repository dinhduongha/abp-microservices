using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

using Volo.Abp.EntityFrameworkCore;

/*
User must change "Administration" to module's name
*/
[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationEntityFrameworkCoreModule),
    typeof(AdministrationApplicationContractsModule)
    )]

public class DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        Configure<AbpDbContextOptions>(options =>
        {
            options.UseNpgsql();
        });
    }
}
