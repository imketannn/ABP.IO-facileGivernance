using CommonModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CommonModule;

public abstract class CommonModuleController : AbpControllerBase
{
    protected CommonModuleController()
    {
        LocalizationResource = typeof(CommonModuleResource);
    }
}
