using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

[DependsOn(
    typeof(AbpSharedHostingAspNetCoreModule)
)]
public class AbpSharedHostingGatewaysModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        
        context.Services.AddReverseProxy()
            .LoadFromConfig(configuration.GetSection("ReverseProxy"));
    }
}