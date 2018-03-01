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
        private readonly NgAppDbContext context;
        private readonly IMapper mapper;

        public FeatureController(NgAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<FeatureViewModel> GetList()
        {
            return mapper.Map<List<Feature>, List<FeatureViewModel>>(context.Feature.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody]FeatureViewModel viewModel){
            var model = new Feature();
            
            return Ok();
        }
    }
}