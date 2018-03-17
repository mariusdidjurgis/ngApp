using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ngApp.Web.Models;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        [Route("api/Home/GetColors")]
        public IList<IdWithNameAndCode> GetColors()
        {
            return Enum.GetValues(typeof(VehicleColor)).Cast<Enum>()
                .Select(s => new IdWithNameAndCode(Convert.ToInt64(s), s.ToString(), s.ToDisplay())).ToList();
        }

        [Route("api/Home/GetRandomNumber")]
        public double GetRandomNumber()
        {
            return (new Random()).NextDouble() * 100;
        }
    }
}
