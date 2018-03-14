using ngApp.Web.Models.Base;
using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Models
{
    public static class ViewModelExtension
    {
        public static IList<IdWithName> ToIdWithName(this IList<EntityWithName> list)
        {
            var result = new List<IdWithName>();

            foreach (var l in list)
                result.Add(new IdWithName(l.Id, l.Name));

            return result;
        }

        //public static void ForAll(this IList<EntityId> list, Action<> action) {

        //}
    }
}
