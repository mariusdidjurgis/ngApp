namespace ngApp.Web.Interfaces.Base
{
    public interface IEntityWithName
    {
         string Name { get; set; }
    }

    public interface IEntityWithCode : IEntityWithName
    {
        string Code { get; set; }
    }
}