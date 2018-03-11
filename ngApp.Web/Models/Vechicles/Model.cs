
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("models")]
    public class Model{
        public long Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public Color Color { get; set; } = Color.Black;
        [Required]
        public long MakeId { get; set; }
        public Make Make{ get; set; }
        public ICollection<ModelFeature> Features { get; set; }
    }
}
