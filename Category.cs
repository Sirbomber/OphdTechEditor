using System.Collections.Generic;

namespace OphdTechEdit
{
    class Category
    {
        public string Name { get; set; }
        public int IconIndex { get; set; }
        public List<Technology> Techs { get; set; } = new List<Technology>();

        public void AddTechnology(Technology technology)
        {
            if (Techs.Contains(technology)) { return; }
            Techs.Add(technology);
        }

        public void RemoveTechnology(uint techId)
        {
            foreach (Technology tech in Techs)
            {
                if (tech.Id == techId)
                {
                    _ = Techs.Remove(tech);
                    return;
                }
            }
        }
    }
}
