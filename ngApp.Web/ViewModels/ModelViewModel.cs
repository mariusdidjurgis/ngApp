using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.ViewModels
{
    public class ModelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IdWithName Color { get; set; }
        public IdWithName Make { get; set; }
        public long MakeId { get; set; }
    }
}