using System.Collections.Generic;

namespace OphdTechEdit
{
    public class Technology
    {
        public string Name { get; set; } = "New Technology";
        public string Description { get; set; } = "";
        public uint Id { get; set; } = 0;
        public uint LabType { get; set; } = 0;
        public uint Cost { get; set; } = 0;
        public List<uint> RequiredTechnologies { get; set; } = new List<uint>();
        public List<Effect> Effects { get; set; } = new List<Effect>();
    }
}
