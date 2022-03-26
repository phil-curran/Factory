using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Machine
{
    [Key]
    public int MachineId { get; set; }
    [Required] 
    public string MachineName { get; set; }
    [Required] 
    public string Description { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
    public Machine()
    {
        this.JoinEntities = new HashSet<EngineerMachine>();
    }
}