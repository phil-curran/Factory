using Microsoft.EntityFrameworkCore;

namespace Factory.Models;

[Keyless]
public class EngineerMachine
{
    // Engineer
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public DateTime CreationDate { get; set; }
    // Machine
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public string Description { get; set; }
    // Virtual
    public virtual Engineer Engineer { get; set; }
    public virtual Machine Machine { get; set; }
}