using System.ComponentModel.DataAnnotations;

namespace ngApp.Web.Models.Vechicles
{
    public class ModelFeature
    {
        public long Id { get; set; }
        [Required]
        public long ModelId { get; set; }
        public Model Model { get; set; }
        [Required]
        public long FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}