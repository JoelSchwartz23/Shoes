using System.ComponentModel.DataAnnotations;

namespace shoes.Models
{
  public class Shoe
  {
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
  }
}