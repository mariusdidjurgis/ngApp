using Microsoft.EntityFrameworkCore;

namespace ngApp.Web.Persistence
{
    public class NgAppDbContext : DbContext
    {
        public NgAppDbContext(DbContextOptions<NgAppDbContext> options): base(options){

        }

        public DbSet<Make> Make { get; set; }
    }
}