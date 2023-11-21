using System;

namespace Game.Core.Systems
{
    public class BaseSystem : IInitSystem, IUpdateSystem, IDisposable
    {
        public virtual void Init()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void Dispose()
        {

        }
    }
}