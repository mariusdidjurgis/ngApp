using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Interfaces.Repositories;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/Feature/[action]")]
    public class FeatureController : MainController<Feature, FeatureViewModel>
    {
        private readonly IUnitOfWork unitOfWork;

        public FeatureController(IUnitOfWork _unitOfWork): base(_unitOfWork, _unitOfWork.Features)
        {
            unitOfWork = _unitOfWork;
        }
    }
}