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
    [Route("api/Feature/[action]")]
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


        [HttpGet]
        [Route("{Id:long}")]
        public FeatureViewModel GetById(long Id)
        {
            var model = Id > 0 ? unitOfWork.Features.Get(Id) : new Feature();

            return mapper.Map<Feature, FeatureViewModel>(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody]FeatureViewModel viewModel){
            var model = mapper.Map<FeatureViewModel, Feature>(viewModel);
            unitOfWork.Features.Add(model);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        [HttpPut]
        public IActionResult Put([FromBody]FeatureViewModel viewModel)
        {
            var model = mapper.Map<FeatureViewModel, Feature>(viewModel);
            unitOfWork.Features.Update(model);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        [HttpDelete("{Id:long}")]
        public IActionResult Delete(long Id)
        {
            unitOfWork.Features.Remove(unitOfWork.Features.Get(Id));
            unitOfWork.Complete();

            return Ok();
        }
    }
}