
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("makes")]
    public class Make{
        public long Id{ get; set; }
        [Required]
        [StringLength(255)]
        public string Name{ get; set; }
        public IList<Model> Models { get; set; }
    }
}
