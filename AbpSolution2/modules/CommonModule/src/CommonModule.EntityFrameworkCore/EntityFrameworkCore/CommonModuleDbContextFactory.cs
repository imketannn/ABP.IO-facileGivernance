using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace CommonModule.EntityFrameworkCore
{
    public class CommonModuleDbContextFactory : IDesignTimeDbContextFactory<CommonModuleDbContext>
    {
        public CommonModuleDbContext CreateDbContext(string[] args)
        {
            // Build configuration
            var configuration = BuildConfiguration();

            // Configure DbContext with the connection string
            var builder = new DbContextOptionsBuilder<CommonModuleDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CommonModuleDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../../src/AbpSolution2.DbMigrator");
            return new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
        }
    }
}
