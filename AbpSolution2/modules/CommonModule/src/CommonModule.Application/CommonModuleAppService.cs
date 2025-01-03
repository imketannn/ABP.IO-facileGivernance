using CommonModule.Localization;
using Volo.Abp.Application.Services;

namespace CommonModule;

public abstract class CommonModuleAppService : ApplicationService
{
    protected CommonModuleAppService()
    {
        LocalizationResource = typeof(CommonModuleResource);
        ObjectMapperContext = typeof(CommonModuleApplicationModule);
    }
}
