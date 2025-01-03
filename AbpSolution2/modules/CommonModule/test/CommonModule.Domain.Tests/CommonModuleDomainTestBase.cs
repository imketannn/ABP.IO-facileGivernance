using Volo.Abp.Modularity;

namespace CommonModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CommonModuleDomainTestBase<TStartupModule> : CommonModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
