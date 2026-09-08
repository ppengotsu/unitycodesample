using System;
using UnityEngine;

namespace tokyo.sysken.sample.main.mainscene
{
    [DefaultExecutionOrder((int)CommonDefine.CommonDefaultExecutionOrder.ExecutionOrder.SceneController)]
    public class MainSceneController : MonoBehaviour
    {
        enum SceneMode : int
        {
           Init=0
           ,Main=1
            
            
            
        }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        private void ChangeMode(SceneMode nextMode)
        {
            switch (nextMode)
            {
                case SceneMode.Init:
                    break;
                case SceneMode.Main:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(nextMode), nextMode, null);
            }
        }
        
        
        
        
        
        

    }
}
