using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CommonModule.EntityFrameworkCore;

[ConnectionStringName(CommonModuleDbProperties.ConnectionStringName)]
public interface ICommonModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
