using UnityEngine;

namespace Game.Units
{
    public class PlayerModel : UnitModel
    {
        public PlayerModel(string name, GameObject unitGO, UnitStats unitStats) 
            : base(name, unitGO, unitStats)
        {
        }
    }
}