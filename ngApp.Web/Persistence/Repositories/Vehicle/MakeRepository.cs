using ngApp.Web.Interfaces.Repositories.Vehicles;
using ngApp.Web.Models.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Persistence.Repositories.Vehicle
{
    public class MakeRepository : Repository<Make>, IMakeRepository
    {
        private NgAppDbContext db;

        public MakeRepository(NgAppDbContext _db) : base(_db)
        {
            db = _db;
        }

    }
}
