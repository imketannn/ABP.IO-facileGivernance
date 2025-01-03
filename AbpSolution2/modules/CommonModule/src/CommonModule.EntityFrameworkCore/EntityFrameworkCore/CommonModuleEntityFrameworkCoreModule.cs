using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CommonModule.EntityFrameworkCore;

[DependsOn(
    typeof(CommonModuleDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CommonModuleEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CommonModuleDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(includeAllEntities: true);
        });
    }
}
