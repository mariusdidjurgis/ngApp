
using ngApp.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("models")]
    public class Model : EntityWithName
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public long MakeId { get; set; }
        public virtual Make Make { get; set; }
        public virtual ICollection<ModelFeature> Features { get; set; } = new List<ModelFeature>();
    }
}
