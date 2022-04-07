using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class EngineerMachine
    {
        // Merge?
        public int EngineerMachineId { get; set; }

        // Engineer
        public int EngineerId { get; set; }

        // Machine
        public int MachineId { get; set; }

        // Virtual
        public virtual Engineer Engineer { get; set; }
        public virtual Machine Machine { get; set; }
    }
}