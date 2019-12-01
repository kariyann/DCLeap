using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRawInput;

/*------------------------------------------------------------------------------------------
 * NOT USED CURRENTLY - WIP
 * ----------------------------------------------------------------------------------------*/

namespace Leap.Unity
{
    public class InputsScript : MonoBehaviour
    {
        bool workInBackground = true;
        public SceneManaging Quit;     

        private void Escape()
        {
            if (RawKeyInput.IsKeyDown(RawKey.Escape) && RawKeyInput.IsKeyDown(RawKey.LeftControl))
            {
                Quit.UnLoadVirtualMouse();
            }         
        }

        void Start()
        {
            RawKeyInput.Start(workInBackground);
        }

        void Update()
        {
            Escape();
        }

        private void OnApplicationQuit()
        {
            RawKeyInput.Stop();
        }
    }
}
