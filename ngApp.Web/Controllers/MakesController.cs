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
    public class MakesController : Controller
    {
        private readonly NgAppDbContext context;
        private readonly IMapper mapper;

        public MakesController(NgAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("api/makes")]
        public IEnumerable<MakeViewModel> GetMakes()
        {
            var list = context.Make.Include(m => m.Models).ToList();
            
            return mapper.Map<List<Make>, List<MakeViewModel>>(list);
        }
    }
}