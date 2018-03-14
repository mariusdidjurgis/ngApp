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
    public class MakeController : MainController<Make, MakeViewModel>
    {
        private readonly IUnitOfWork unitOfWork;

        public MakeController(IUnitOfWork _unitOfWork): base(_unitOfWork, _unitOfWork.Make)
        {
            unitOfWork = _unitOfWork;
        }
        
        public IList<MakeViewModel> GetList()
        {
            var vList = new List<MakeViewModel>();
            var list = unitOfWork.Make.GetAllWithModels();
            foreach (var l in list)
                vList.Add(new MakeViewModel(l));
            
            return vList;
        }
    }
}