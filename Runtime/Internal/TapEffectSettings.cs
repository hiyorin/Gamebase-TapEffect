using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gamebase.TapEffect.Internal
{
    [Serializable]
    internal sealed class TapEffectSettings
    {
        [SerializeField] private TapEffectBase[] prefabs = {};
        
        [SerializeField] private bool defaultEnable = false;

        public IEnumerable<TapEffectBase> Prefabs => prefabs;
        
        public bool DefaultEnable => defaultEnable;
    }
}