using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ngApp.Web.Persistence
{
   public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NgAppDbContext>
    {
        public NgAppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<NgAppDbContext>();
            
            var connectionString = configuration["ConnectionString:Default"];
            var connectionString_1 = configuration.GetConnectionString("Default");

            builder.UseSqlServer(connectionString);
            return new NgAppDbContext(builder.Options);
        }
    }
}