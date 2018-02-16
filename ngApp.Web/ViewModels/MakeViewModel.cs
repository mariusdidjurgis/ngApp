using System.Collections.Generic;

namespace ngApp.Web.ViewModels
{
    public class MakeViewModel
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public IList<ModelViewModel> Models { get; set; }
    }
}