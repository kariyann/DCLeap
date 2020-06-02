using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;


namespace Leap.unity
{
    public class FlashLight : MonoBehaviour
    {
        InputSimulator sim;
        // Start is called before the first frame update
        void Start()
        {
            sim = new InputSimulator();
        }
        void LALT_Keydown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.MENU);
        }

        IEnumerator F_KeyDown()
        {
            yield return new WaitForSeconds(0.05f);
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
        }

        IEnumerator F_KeyUp()
        {
            yield return new WaitForSeconds(0.1f);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
        }

        IEnumerator LALT_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.15f);
            sim.Keyboard.KeyUp(VirtualKeyCode.MENU);
        }

        IEnumerator CoroutineDestructor()
        {
            yield return new WaitForSeconds(0.2f);
            StopAllCoroutines();
        }

        public void Turn_FlashLight()
        {
            LALT_Keydown();
            StartCoroutine(F_KeyDown());
            StartCoroutine(F_KeyUp());
            StartCoroutine(LALT_DelayedKeyUp());
            StartCoroutine(CoroutineDestructor());
        }
    }
}

