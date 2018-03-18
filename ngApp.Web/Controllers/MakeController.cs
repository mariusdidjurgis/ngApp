using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;
using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MakeController : MainController<Make, MakeViewModel>
    {
        private readonly IUnitOfWork unitOfWork;

        public MakeController(IUnitOfWork _unitOfWork): base(_unitOfWork, _unitOfWork.Make)
        {
            unitOfWork = _unitOfWork;
        }

        public IList<IdWithName> GetSmallList()
        {
            return unitOfWork.Make.GetIdWithNameAll();
        }

    }
}