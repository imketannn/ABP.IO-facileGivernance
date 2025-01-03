using CommonModule.Common;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CommonModule.EntityFrameworkCore;

public static class CommonModuleDbContextModelCreatingExtensions
{
    public static void ConfigureCommonModule(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(CommonModuleDbProperties.DbTablePrefix + "Questions", CommonModuleDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Keyword>(b =>
        {
            b.ToTable(CommonModuleDbProperties.DbTablePrefix + "Keywords", CommonModuleDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Industry>(b =>
        {
            b.ToTable(CommonModuleDbProperties.DbTablePrefix + "Industry", CommonModuleDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<SalesPosition>(b =>
        {
            b.ToTable(CommonModuleDbProperties.DbTablePrefix + "SalesPositions", CommonModuleDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Type>(b =>
        {
            b.ToTable(CommonModuleDbProperties.DbTablePrefix + "Types", CommonModuleDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
