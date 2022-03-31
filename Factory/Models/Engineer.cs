namespace Factory.Models;

public class Engineer
{
    public Engineer()
    {
        JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public DateTime CreationDate { get; set; }
    public ICollection<EngineerMachine> JoinEntities { get; set; }
}