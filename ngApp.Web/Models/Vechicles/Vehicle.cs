using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("vehicles")]
    public class Vehicle
    {
        public long Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Mileage { get; set; }
        [Required]
        public double Power { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public long ModelId { get; set; }
        public virtual Model Model { get; set; }
    }
}