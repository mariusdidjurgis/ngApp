using ngApp.Web.Interfaces.Base;
using System.ComponentModel.DataAnnotations;

namespace ngApp.Web.Models.Base
{
    public class EntityWithName : EntityId, IEntityWithName
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }        
    }

    public class EntityWithCode : EntityWithName, IEntityWithCode
    {
        public string Code { get; set; }
    }
}