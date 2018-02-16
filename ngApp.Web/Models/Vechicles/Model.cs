
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("models")]
public class Model{
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; }
    public Make Make{ get; set; }
}