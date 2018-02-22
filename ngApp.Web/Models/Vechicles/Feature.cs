using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("features")]
    public class Feature
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}