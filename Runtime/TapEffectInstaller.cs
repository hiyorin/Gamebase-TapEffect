using Gamebase.TapEffect.Internal;
using UnityEngine;
using Zenject;

namespace Gamebase.TapEffect
{
    [CreateAssetMenu(fileName = "TapEffectInstaller", menuName = "Installers/Gamebase/TapEffectInstaller")]
    public sealed class TapEffectInstaller : ScriptableObjectInstaller<TapEffectInstaller>
    {
        [SerializeField] private TapEffectSettings settings = null;
        
        public override void InstallBindings()
        {
            Container.Bind<ITapEffectController>()
                .FromSubContainerResolve()
                .ByMethod(InstallSubContainer)
                .WithKernel()
                .AsSingle();
        }

        private void InstallSubContainer(DiContainer subContainer)
        {
            subContainer.BindInterfacesTo<TapEffectManager>().AsSingle();
            subContainer.BindInstance(settings).AsSingle();
        }
    }
}
