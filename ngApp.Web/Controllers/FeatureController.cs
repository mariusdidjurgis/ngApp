using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class FeatureController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public FeatureController(IUnitOfWork _unitOfWork, IMapper mapper)
        {
            this.mapper = mapper;
            unitOfWork = _unitOfWork;
        }

        public IEnumerable<FeatureViewModel> GetList()
        {            
            return mapper.Map<List<Feature>, List<FeatureViewModel>>(unitOfWork.Features.GetAll().ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody]FeatureViewModel viewModel){
            //var model = mapper.Map<FeatureViewModel, Feature>(viewModel);
            //unitOfWork.Features.Add(model);
            //unitOfWork.Complete();

            return Ok();
        }


    }
}