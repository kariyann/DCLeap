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
            if (RawKeyInput.IsKeyDown(RawKey.Escape) && RawKeyInput.IsKeyDown(RawKey.LeftControl))    //If LCTRL + ESCAPE pressed
            {
                Quit.UnLoadVirtualMouse();        //call SceneManaging.cs UnLoadVirtualMouse() method
            }         
        }

        void Start()
        {
            RawKeyInput.Start(workInBackground);    //launch RawKeyInput listener
        }

        void Update()
        {
            Escape();                               //listen to LCTRL + ESCAPE press to quit DCLeap Scene
        }

        private void OnApplicationQuit()
        {
            RawKeyInput.Stop();                     //On DCLeap quit, terminate the listener
        }
    }
}
