namespace ngApp.Web.Interfaces.Base
{
    public interface IEntity
    {
         bool IsNew { get; }
    }

    public interface IEntityId: IEntity
    {
        long Id { get; set; }
    }
}