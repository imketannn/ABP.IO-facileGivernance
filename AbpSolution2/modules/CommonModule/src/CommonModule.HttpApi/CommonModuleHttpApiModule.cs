using Localization.Resources.AbpUi;
using CommonModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CommonModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CommonModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CommonModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
