using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace CommonModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CommonModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CommonModuleInstallerModule>();
        });
    }
}
