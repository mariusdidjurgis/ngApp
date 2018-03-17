using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Models.Vechicles
{
    public enum VehicleColor
    {
        [Display(Name = "Red")]
        Red,
        [Display(Name = "Blue")]
        Blue,
        [Display(Name = "Black")]
        Black,
        [Display(Name = "White")]
        White
    }
}
