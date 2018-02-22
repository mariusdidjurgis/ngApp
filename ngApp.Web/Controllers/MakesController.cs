using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MakesController : Controller
    {
        private readonly NgAppDbContext context;
        private readonly IMapper mapper;

        public MakesController(NgAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<MakeViewModel> GetList()
        {
            var list = context.Make.Include(m => m.Models).ToList();
            
            return mapper.Map<List<Make>, List<MakeViewModel>>(list);
        }

        [HttpPost]
        public IActionResult Post([FromBody]MakeViewModel viewModel){
            var model = new Make();
            
            return Ok();
        }
    }
}