using System;
using System.Collections.Generic;

namespace ngApp.Web.ViewModels
{
    public class MakeViewModel
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public DateTime Date { get; set; }
        public string HeadQuatersLocation { get; set; }
        public IList<ModelViewModel> Models { get; set; }
    }
}