using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.ViewModels
{
    public class FeatureViewModel : BaseNameViewModel<Feature>
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public FeatureViewModel() { }
        public FeatureViewModel(Feature model) : base(model)
        {
            Code = model.Code;
            Description = model.Description;
        }

        public override void GetUpdatedModel(Feature model)
        {
            base.GetUpdatedModel(model);
            model.Code = Code;
            model.Description = Description;
        }

    }
}