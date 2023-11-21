using Game.Models;
using Game.Stats.Unit;
using UnityEngine;

namespace Game.Builders
{
    public class UnitBuilder
    {
        private GameObject _unitPrefab;
        private UnitStats _stats;
        private string _name;

        public UnitBuilder New()
        {
            Reset();

            return this;
        }

        public UnitBuilder WithSkin(GameObject prefab)
        {
            _unitPrefab = prefab;

            return this;
        }

        public UnitBuilder WithName(string name)
        { 
            _name = name;

            return this;
        }

        public UnitBuilder WithStats(UnitStats stats)
        {
            _stats = stats;

            return this;
        }

        public UnitModel Build()
        {
            var unitGO = Object.Instantiate(_unitPrefab);
            var model = new UnitModel(_name, unitGO, _stats);
            return model;
        }

        private void Reset()
        {
            _unitPrefab = null;
            _stats = null;
        }
    }
}