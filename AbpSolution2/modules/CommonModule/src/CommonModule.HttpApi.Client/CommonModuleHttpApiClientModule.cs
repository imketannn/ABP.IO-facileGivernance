using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CommonModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CommonModuleApplicationContractsModule).Assembly,
            CommonModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CommonModuleHttpApiClientModule>();
        });

    }
}
