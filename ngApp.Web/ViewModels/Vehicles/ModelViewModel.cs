using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace ngApp.Web.ViewModels
{
    public class ModelViewModel : BaseNameViewModel<Model>
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public IdWithName Make { get; set; }
        public long MakeId { get; set; }
        public IList<FeatureViewModel> features { get; set; } = new List<FeatureViewModel>();

        public ModelViewModel(){ }
        public ModelViewModel(Model model) : base(model)
        {
            Date = model.Date;
            Make = new IdWithName(model.Make?.Id ?? 0, model.Make?.Name); //lazy loading 
            MakeId = model.MakeId;

            foreach (var f in model.Features)
                features.Add(new FeatureViewModel(f.Feature));
        }

        public override void GetUpdatedModel(Model model)
        {
            base.GetUpdatedModel(model);
            model.Date = Date;
            model.MakeId = MakeId;
        }
    }
}