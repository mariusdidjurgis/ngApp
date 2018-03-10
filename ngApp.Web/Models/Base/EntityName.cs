using ngApp.Web.Interfaces.Base;

namespace ngApp.Web.Models.Base
{
    public class EntityWithName : EntityId, IEntityWithName
    {
        public string Name { get; set; }        
    }

    public class EntityWithCode : EntityWithName, IEntityWithCode
    {
        public string Code { get; set; }
    }
}