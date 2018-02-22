
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
        public long MakeId { get; set; }

        public Make Make{ get; set; }
    }
}
