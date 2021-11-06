using System.Collections.Generic;
using System.Diagnostics;

namespace OphdTechEdit
{
    public class Effect
    {
        public static Dictionary<string, Modifier> StringToModifier = new Dictionary<string, Modifier>()
        {
            { "agriculture", Modifier.AgricutureEfficiency },
            { "breakdown", Modifier.BreakdownRate },
            { "education", Modifier.EducationEfficiency },
            { "maintenance_cost", Modifier.MaintenanceCost },
            { "pop_fertility", Modifier.PopulationFertility },
            { "pop_morale", Modifier.PopulationMorale },
            { "pop_mortality", Modifier.PopulationMortality },
            { "recycling", Modifier.RecyclingEfficiency },
            { "smelter", Modifier.SmelterEfficiency },
            { "structure_cost", Modifier.StructureCost },
            { "structure_decay", Modifier.StructureDecay }
        };
        public static Dictionary<string, Unlock> StringToUnlock = new Dictionary<string, Unlock>()
        {
            { "disaster_prediction", Unlock.DisasterPrediction },
            { "robot", Unlock.Robot },
            { "satellite", Unlock.Satellite },
            { "structure", Unlock.Structure },
            { "vehicle", Unlock.Vehicle }
        };
        public static Dictionary<Modifier, string> ModifierToString = new Dictionary<Modifier, string>()
        {
            { Modifier.AgricutureEfficiency, "agriculture" },
            { Modifier.BreakdownRate, "breakdown" },
            { Modifier.EducationEfficiency, "education" },
            { Modifier.MaintenanceCost, "maintenance_cost" },
            { Modifier.PopulationFertility, "pop_fertility" },
            { Modifier.PopulationMorale, "pop_morale" },
            { Modifier.PopulationMortality, "pop_mortality" },
            { Modifier.RecyclingEfficiency, "recycling" },
            { Modifier.SmelterEfficiency, "smelter" },
            { Modifier.StructureCost, "structure_cost" },
            { Modifier.StructureDecay, "structure_decay" }
        };
        public static Dictionary<Unlock, string> UnlockToString = new Dictionary<Unlock, string>()
        {
            { Unlock.DisasterPrediction, "disaster_prediction" },
            { Unlock.Robot, "robot" },
            { Unlock.Satellite, "satellite" },
            { Unlock.Structure, "structure" },
            { Unlock.Vehicle, "vehicle" }
        };
        public static Dictionary<Modifier, string> ModifierToDescription = new Dictionary<Modifier, string>()
        {
            { Modifier.AgricutureEfficiency, "Agriculture Efficiency" },
            { Modifier.BreakdownRate, "Breakdown Rate" },
            { Modifier.EducationEfficiency, "Education" },
            { Modifier.MaintenanceCost, "Maintenance Cost" },
            { Modifier.PopulationFertility, "Population Fertility" },
            { Modifier.PopulationMorale, "Population Morale" },
            { Modifier.PopulationMortality, "Population Mortality" },
            { Modifier.RecyclingEfficiency, "Recycling Efficiency" },
            { Modifier.SmelterEfficiency, "Smelter Efficiency" },
            { Modifier.StructureCost, "Structure Cost" },
            { Modifier.StructureDecay, "Structure Decay" }
        };
        public static Dictionary<Unlock, string> UnlockToDescription = new Dictionary<Unlock, string>()
        {
            { Unlock.DisasterPrediction, "Disaster Prediction" },
            { Unlock.Robot, "Robot" },
            { Unlock.Satellite, "Satellite" },
            { Unlock.Structure, "Structure" },
            { Unlock.Vehicle, "Vehicle" }
        };

        public enum Type
        {
            Modifier,
            Unlock
        }

        public enum Modifier
        {
            Undefined,

            AgricutureEfficiency,
            BreakdownRate,
            EducationEfficiency,
            MaintenanceCost,
            PopulationFertility,
            PopulationMorale,
            PopulationMortality,
            RecyclingEfficiency,
            SmelterEfficiency,
            StructureCost,
            StructureDecay
        }

        public enum Unlock
        {
            Undefined,

            DisasterPrediction,
            Robot,
            Satellite,
            Structure,
            Vehicle
        }

        private Modifier modifier;
        private Unlock unlock;

        public object Value { get; set; }
        public Type EffectType { get; set; }

        public Modifier Modifies
        {
            get
            {
                Trace.Assert(EffectType == Type.Modifier);
                return modifier;
            }
            set
            {
                modifier = value;
            }
        }

        public Unlock Unlocks
        {
            get
            {
                Trace.Assert(EffectType == Type.Unlock);
                return unlock;
            }
            set
            {
                unlock = value;
            }

        }

        public override string ToString()
        {
            string outString;


            if (EffectType == Type.Modifier)
            {
                outString = "Modifies: " + ModifierToDescription[Modifies] + " \"" + Value.ToString() + "\"";
            }
            else
            {
                outString = "Unlocks: " + UnlockToDescription[Unlocks] + " \"" + Value.ToString() + "\"";
            }

            return outString;
        }

    }
}
