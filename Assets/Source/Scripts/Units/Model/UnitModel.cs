using UnityEngine;

namespace Game.Units
{
    public class UnitModel
    {
        public string Name { get; private set; }
        public GameObject UnitGO { get; private set; }
        public UnitStats UnitStats { get; set; }

        public UnitModel(string name, GameObject unitGO, UnitStats unitStats)
        {
            Name = name;
            UnitGO = unitGO;
            UnitStats = unitStats;
        }
    }
}