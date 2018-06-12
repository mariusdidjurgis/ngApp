using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ModelController : MainController<Model, ModelViewModel>
    {
        private readonly IUnitOfWork unitOfWork;

        public ModelController(IUnitOfWork _unitOfWork): base(_unitOfWork, _unitOfWork.Model)
        {
            unitOfWork = _unitOfWork;
        }
     
        protected override void OnGet(ModelViewModel viewModel)
        {
            base.OnGet(viewModel);
        }

        protected override void OnPost(Model model, ModelViewModel viewModel)
        {
            base.OnPost(model, viewModel);
            if (viewModel.features != null)
            {
                var fList = model.Features.ToList();
                var featuresCount = model.Features.Count;
                for (var i = 0; i < featuresCount; i++)
                {
                    var ff = fList[i];
                    model.Features.Remove(ff);
                }

                foreach (var f in viewModel.features)
                {
                    var fe = unitOfWork.Features.GetAll().ToList().Where(x => x.Id == f.Id).Single();
                    var fm = new ModelFeature() {
                        ModelId = model.Id,
                        FeatureId = fe.Id
                    };

                    model.Features.Add(fm);
                }
            }
        }
        
    }
}