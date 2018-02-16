using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Persistence;

namespace ngApp.Web.Controllers
{
    public class MakesController : Controller
    {
        private readonly NgAppDbContext context;

        public MakesController(NgAppDbContext context)
        {
            this.context = context;

        }

        [HttpGet("api/makes")]
        public IEnumerable<Make> GetMakes()
        {
            return context.Make.Include(m => m.Models).ToList();
        }
    }
}