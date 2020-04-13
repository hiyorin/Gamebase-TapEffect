using UnityEngine;
using Zenject;

namespace Gamebase.TapEffect.NodeCanvas
{
    public sealed class TapEffectTaskManager : MonoBehaviour
    {
        [Inject] internal ITapEffectController Controller { get; } = default;
    }
}