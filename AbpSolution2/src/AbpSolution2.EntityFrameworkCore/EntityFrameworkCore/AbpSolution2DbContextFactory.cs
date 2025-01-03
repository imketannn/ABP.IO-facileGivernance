using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AbpSolution2.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpSolution2DbContextFactory : IDesignTimeDbContextFactory<AbpSolution2DbContext>
{
    public AbpSolution2DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpSolution2EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpSolution2DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpSolution2DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpSolution2.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
