
using ngApp.Web.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("models")]
    public class Model : EntityWithName
    {
        public Color Color { get; set; } = Color.Black;
        public long MakeId { get; set; }
        public Make Make { get; set; }
        public ICollection<ModelFeature> Features { get; set; } = new List<ModelFeature>();
    }
}
