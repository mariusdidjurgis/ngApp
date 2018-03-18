using System.ComponentModel.DataAnnotations;

namespace ngApp.Web.Models.Vechicles
{
    public class ModelFeature
    {
        public long Id { get; set; }
        [Required]
        public long ModelId { get; set; }
        public virtual Model Model { get; set; }
        [Required]
        public long FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
    }
}