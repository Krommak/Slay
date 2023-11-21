using Game.Units;
using System;
using UnityEngine;

namespace Game.Inject
{
    [Serializable]
    public class PlayerSettings
    {
        public GameObject PlayerPrefab;
        [SerializeField]
        private int _hp;
        [SerializeField]
        private int _armor;
        [SerializeField]
        private int _damage;
        [SerializeField]
        private int _movementSpeed;

        public UnitStats GetStats()
        {
            return new UnitStats(_hp, _armor, _damage, _movementSpeed);
        }
    }
}
