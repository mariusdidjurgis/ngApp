using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.ViewModels
{
    public class FeatureViewModel : BaseNameViewModel<Feature>
    {
        public string Code { get; set; }

        public FeatureViewModel() { }
        public FeatureViewModel(Feature model) : base(model)
        {
            Code = model.Code;
        }

        public override void GetUpdatedModel(Feature model)
        {
            base.GetUpdatedModel(model);
            model.Code = Code;
        }

    }
}