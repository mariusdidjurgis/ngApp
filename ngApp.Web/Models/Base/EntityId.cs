using ngApp.Web.Interfaces.Base;

namespace ngApp.Web.Models.Base
{
    public class EntityId : IEntityId
    {
        public long Id { get; set; }

        public bool IsNew { get { return Id < 1; } }
    }
}