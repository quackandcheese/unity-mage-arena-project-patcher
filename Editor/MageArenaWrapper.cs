using Nomnom.UnityProjectPatcher.Editor;
using Nomnom.UnityProjectPatcher.Editor.Steps;

namespace quackandcheese.MageArenaProjectPatcher.Editor
{
    [UPPatcher("com.quackandcheese.unity-mage-arena-project-patcher")]
    public static class MageArenaWrapper
    {
        public static void GetSteps(StepPipeline stepPipeline)
        {
            stepPipeline.SetInputSystem(InputSystemType.InputManager_Old);
            stepPipeline.SetGameViewResolution("16:9");
            stepPipeline.OpenSceneAtEnd("Bootstrap");
        }
    }
}