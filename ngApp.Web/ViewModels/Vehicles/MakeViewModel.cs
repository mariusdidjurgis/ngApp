using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace ngApp.Web.ViewModels
{
    public class MakeViewModel : BaseNameViewModel<Make>
    {
        public DateTime Date { get; set; }
        public string HeadQuatersLocation { get; set; }
        public IList<ModelViewModel> Models { get; set; } = new List<ModelViewModel>();

        public MakeViewModel() { }
        public MakeViewModel(Make model) : base(model)
        {
            Date = model.Date;
            HeadQuatersLocation = model.HeadQuatersLocation;

            foreach (var m in model.Models)
                Models.Add(new ModelViewModel(m));
        }

        public override void GetUpdatedModel(Make model)
        {
            base.GetUpdatedModel(model);
            model.Date = Date;
            model.HeadQuatersLocation = HeadQuatersLocation;
        }
    }
}