using JetBrains.Annotations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Gamebase.TapEffect.NodeCanvas.Actions
{
    [PublicAPI]
    [Name("Change Tap Effect")]
    [Category("✫ Gamebase/TapEffect")]
    public sealed class ChangeTapEffect : ActionTask<TapEffectTaskManager>
    {
        [RequiredField] public BBParameter<string> name = default;

        protected override string info => $"Tap Effect {name}";
        
        protected override void OnExecute()
        {
            agent.Controller.Change(name.value);
            EndAction(true);
        }
    }
}