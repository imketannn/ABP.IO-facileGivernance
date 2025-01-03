using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CommonModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CommonModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CommonModuleConsoleApiClientModule : AbpModule
{

}
