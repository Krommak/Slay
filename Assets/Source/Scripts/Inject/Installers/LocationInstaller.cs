using UnityEngine;
using Zenject;
using Game.Units;

namespace Game.Inject
{
    public class LocationInstaller : MonoInstaller
    {
        [SerializeField]
        private PlayerSettings _playerSettings;

        private UnitBuilder _unitBuilder;

        public override void InstallBindings()
        {
            BindPlayer();
        }

        public void BindPlayer()
        {
            var playerModel = _unitBuilder.New()
                .WithName("Player")
                .WithStats(_playerSettings.GetStats())
                .WithSkin(_playerSettings.PlayerPrefab)
                .BuildAs<PlayerModel>();

            Container.Bind<PlayerModel>()
                .FromInstance(playerModel)
                .AsSingle()
                .NonLazy();

            Container.QueueForInject(playerModel);
        }
    }
}