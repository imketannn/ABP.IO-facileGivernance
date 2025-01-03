using CommonModule.Common;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CommonModule.EntityFrameworkCore;

[ConnectionStringName(CommonModuleDbProperties.ConnectionStringName)]
public class CommonModuleDbContext : AbpDbContext<CommonModuleDbContext>, ICommonModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Industry> Industry { get; set; }
    public DbSet<Keyword> Keywords { get; set; }
    public DbSet<SalesPosition> SalesPositions { get; set; }
    public DbSet<Type> Types { get; set; }
    public CommonModuleDbContext(DbContextOptions<CommonModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCommonModule();

        builder.Entity<Industry>(b =>
        {
            b.ToTable("Industry");
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(250);
        });

        builder.Entity<Keyword>(b =>
        {
            b.ToTable("Keywords");
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(250);
        });

        builder.Entity<SalesPosition>(b =>
        {
            b.ToTable("SalesPositions");
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(250);
        });

        builder.Entity<Type>(b =>
        {
            b.ToTable("Types");
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(250);
        });
    }
}
