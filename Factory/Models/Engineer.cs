using System.ComponentModel.DataAnnotations;

namespace Factory.Models;

public class Engineer
{
    [Key]
    public int EngineerId { get; set; }
    [Required]
    public string EngineerName { get; set; }
    [Required]
    public DateTime CreationDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
    
    public Engineer()
    {
        this.JoinEntities = new HashSet<EngineerMachine>();
    }
}