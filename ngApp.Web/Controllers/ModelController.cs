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
    }
}