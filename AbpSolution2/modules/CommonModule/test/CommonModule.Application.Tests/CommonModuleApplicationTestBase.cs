using Volo.Abp.Modularity;

namespace CommonModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CommonModuleApplicationTestBase<TStartupModule> : CommonModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
