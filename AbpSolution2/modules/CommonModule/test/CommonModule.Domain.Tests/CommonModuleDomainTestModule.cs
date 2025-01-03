using Volo.Abp.Modularity;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleDomainModule),
    typeof(CommonModuleTestBaseModule)
)]
public class CommonModuleDomainTestModule : AbpModule
{

}
