using Volo.Abp.Modularity;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleApplicationModule),
    typeof(CommonModuleDomainTestModule)
    )]
public class CommonModuleApplicationTestModule : AbpModule
{

}
