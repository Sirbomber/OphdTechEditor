using System.Collections.Generic;

namespace OphdTechEdit
{
    static class Globals
    {
        public static List<Category> Categories = new List<Category>();


        public static bool CategoryNameInUse(string name)
        {
            return Globals.Categories.Find(x => x.Name == name) != null;
        }

        public static Technology FindTechnologyById(uint id)
        {
            foreach(Category category in Categories)
            {
                Technology tech = category.Techs.Find(x => x.Id == id);

                if(tech != null)
                {
                    return tech;
                }
            }

            return null;
        }

        public static void PurgeTechnologyReferences(uint id)
        {
            foreach (Category category in Categories)
            {
                foreach (Technology technology in category.Techs)
                {
                    _ = technology.RequiredTechnologies.Remove(id);
                }
            }
        }

        public static void UpdateTechIdReferences(uint previousId, uint newId)
        {
            foreach (Category category in Categories)
            {
                foreach (Technology technology in category.Techs)
                {
                    int techRefIndex = technology.RequiredTechnologies.FindIndex(x => x == previousId);

                    if (techRefIndex != -1)
                    {
                        technology.RequiredTechnologies[techRefIndex] = newId;
                    }
                }
            }
        }

        public static bool TechNameInUse(string name)
        {
            foreach (Category category in Categories)
            {
                Technology tech = category.Techs.Find(x => x.Name == name);

                if (tech != null)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool TechIdInUse(uint id, string name)
        {
            foreach (Category category in Categories)
            {
                Technology tech = category.Techs.Find(x => x.Id == id);

                if (tech != null && tech.Name != name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
