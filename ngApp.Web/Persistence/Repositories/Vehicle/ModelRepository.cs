using ngApp.Web.Interfaces.Repositories.Vehicles;
using ngApp.Web.Models.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Persistence.Repositories.Vehicle
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
        private NgAppDbContext db;

        public ModelRepository(NgAppDbContext _db) : base(_db)
        {
            db = _db;
        }
        
    }
}
