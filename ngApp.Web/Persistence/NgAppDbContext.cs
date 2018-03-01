using Microsoft.EntityFrameworkCore;
using ngApp.Web.EntityConfigurations;
using ngApp.Web.EntityConfigurations.Base;
using ngApp.Web.Models.Vechicles;

namespace ngApp.Web.Persistence
{
    public class NgAppDbContext : DbContext
    {
        public NgAppDbContext(DbContextOptions<NgAppDbContext> options): base(options){

        }

        public DbSet<Make> Make { get; set; }
        public DbSet<Vehicle> Vehicle{ get; set; }
        public DbSet<Feature> Feature { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new FeatureConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}