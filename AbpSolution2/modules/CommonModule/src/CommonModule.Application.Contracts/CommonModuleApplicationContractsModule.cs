using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CommonModuleApplicationContractsModule : AbpModule
{

}
