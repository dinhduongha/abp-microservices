using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

using Bamboo.Admin;
using Bamboo.Admin.EntityFrameworkCore;

/*
User must change "Administration" to module's name
*/
[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdminEntityFrameworkCoreModule),
    typeof(AdminApplicationContractsModule)
    )]

public class DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
