using DuckLib.Core.Installers;
using DuckLib.Core.Services;
using DuckLib.Core.View;
using Gameplay.Game.Features.Cleanup.Systems;
using Gameplay.Game.Features.Initialize.Systems;
using Gameplay.Game.Features.View.Systems;
using Gameplay.Game.Services;

namespace Gameplay.Game.Installers
{
    public class GameInstaller : EcsInstaller
    {
        public override void InstallBindings()
        {
            InstallContexts();
            InstallServices();
            InstallSystems();
            base.InstallBindings();
        }

        private void InstallContexts()
        {
            Container.BindInterfacesAndSelfTo<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            Container.BindInterfacesAndSelfTo<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
            Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
        }

        private void InstallServices()
        {
            Container.BindInterfacesTo<GameViewService>().AsSingle();
            Container.BindInterfacesTo<GameCollidingViewRegister>().AsSingle();
            Container.Bind<IIdentifierService>().To<GameIdentifierService>().AsSingle();
        }

        private void InstallSystems()
        {
            // init systems
            InstallCommonSystem<InitializeSystem>();

            // execute/reactive systems
            InstallUpdateSystem<ViewSystem>();

            // event systems
            InstallUpdateSystem<GameEventSystems>();

            // cleanup
            InstallUpdateSystem<GameCleanupSystems>();
            InstallCommonSystem<DestroyAllEntitiesSystem>();
        }
    }
}