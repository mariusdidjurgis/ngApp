using Microsoft.EntityFrameworkCore;
using ngApp.Web.Models.Vechicles;

namespace ngApp.Web.Persistence
{
    public class NgAppDbContext : DbContext
    {
        public NgAppDbContext(DbContextOptions<NgAppDbContext> options): base(options){

        }

        public DbSet<Make> Make { get; set; }
        public DbSet<Vehicle> Vehicle{ get; set; }
    }
}