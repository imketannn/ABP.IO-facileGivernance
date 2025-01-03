using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using CommonModule.Common;

namespace CommonModule;

[DependsOn(
    typeof(CommonModuleDomainModule),
    typeof(CommonModuleApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class CommonModuleApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<CommonModuleApplicationModule>();
        context.Services.AddScoped<KeywordAppService>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CommonModuleApplicationModule>(validate: true);
        });
    }
}
