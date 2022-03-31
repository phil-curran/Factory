namespace Factory.Models;

public class Machine
{
    public Machine()
    {
        JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public string Description { get; set; }
    public ICollection<EngineerMachine> JoinEntities { get; set; }
}