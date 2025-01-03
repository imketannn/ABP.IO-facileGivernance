using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CommonModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CommonModuleDomainSharedModule)
)]
public class CommonModuleDomainModule : AbpModule
{

}
