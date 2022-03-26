using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Machine
{
    [Key]
    public int MachineId { get; set; }
    [Required]
    public string MachineName { get; set; }
}