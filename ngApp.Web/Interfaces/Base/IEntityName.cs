namespace ngApp.Web.Interfaces.Base
{
    public interface IEntityName
    {
         string Name { get; set; }
    }

    public interface IEntityCode: IEntityName
    {
        string Code { get; set; }
    }
}