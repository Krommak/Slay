using Game.Core.Systems;
using UnityEngine.InputSystem;
using Zenject;

namespace Game.Features.Input
{
    public sealed class InputSystem : BaseSystem
    {
        private InputActionAsset _input;

        [Inject]
        public InputSystem(InputActionAsset inputs)
        {
            _input = inputs;
        }

        public override void Init()
        {

        }

        public override void Dispose()
        {

        }
    }
}