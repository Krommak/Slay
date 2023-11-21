using Game.Stats.Unit;
using System;
using UnityEngine;

namespace Game.Settings
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
