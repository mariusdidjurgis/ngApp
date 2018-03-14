using ngApp.Web.Models.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Interfaces.Repositories.Vehicles
{
    public interface IModelRepository : IRepository<Model>
    {
        IList<Model> GetAllWithMake();
    }
}
