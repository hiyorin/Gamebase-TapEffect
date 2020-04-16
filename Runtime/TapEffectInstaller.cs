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
            Container.BindInterfacesTo<TapEffectManager>()
                .FromSubContainerResolve()
                .ByMethod(InstallSubContainer)
                .WithKernel()
                .AsSingle();
        }

        private void InstallSubContainer(DiContainer subContainer)
        {
            subContainer.Bind<TapEffectManager>().AsSingle();
            subContainer.BindInstance(settings).AsSingle();
        }
    }
}
