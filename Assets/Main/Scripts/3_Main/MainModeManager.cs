using UnityEngine;

namespace tokyo.sysken.sample.main.mainscene
{
    public class MainModeManagerr:BaseModeManager
    {
        public override void InitMode()
        {
            base.InitMode();
        }

        public override void StartMode()
        {
            base.StartMode();
        }

        public override void EndMode()
        {
            base.EndMode();

            _onEndModeAction.Invoke();
        }
    }
}