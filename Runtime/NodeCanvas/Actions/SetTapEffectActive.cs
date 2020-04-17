using JetBrains.Annotations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Gamebase.TapEffect.NodeCanvas.Actions
{
    [PublicAPI]
    [Name("Change Tap Effect")]
    [Category("✫ Gamebase/TapEffect")]
    public sealed class SetTapEffectActive : ActionTask<TapEffectTaskManager>
    {
        [RequiredField] public BBParameter<bool> active = default;
        
        protected override string info => $"Tap Effect {(active.value ? "Enable" : "Disable")}";
        
        protected override void OnExecute()
        {
            if (active.value)
                agent.Controller.Enable();
            else
                agent.Controller.Disable();
            EndAction(true);
        }
    }
}