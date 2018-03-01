using ngApp.Web.Interfaces.Base;

namespace ngApp.Web.Models.Base
{
    public class EntityName : EntityId, IEntityName
    {
        public string Name { get; set; }        
    }

    public class EntityCode : EntityName, IEntityCode
    {
        public string Code { get; set; }
    }
}