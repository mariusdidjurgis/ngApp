using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Interfaces.Repositories.Vehicles
{
    public interface IMakeRepository : IRepository<Make>
    {
        IList<Make> GetAllWithModels();
        IList<IdWithName> GetIdWithNameAll();
    }
}
