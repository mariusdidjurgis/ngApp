using System.ComponentModel.DataAnnotations;

namespace ngApp.Web.Models.Vechicles
{
    public class VehicleFeature
    {
        public long Id { get; set; }
        [Required]
        public long VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        [Required]
        public long FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}