using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Engineer
{
    [Key]
    public int EngineerId { get; set; }
    [Required]
    public string EngineerName { get; set; }
}