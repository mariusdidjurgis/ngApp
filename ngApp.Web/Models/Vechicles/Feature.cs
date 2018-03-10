using ngApp.Web.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{

    public class Feature: EntityWithCode
    {
        public decimal Price { get; set; }
        public bool Active { get; set; }
    }
}