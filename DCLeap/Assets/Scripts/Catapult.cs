using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;

namespace Leap.Unity
{
    public class Catapult : MonoBehaviour
    {
        InputSimulator sim;
        Coroutine Co;

        // Start is called before the first frame update
        void Start()
        {
            sim = new InputSimulator();
        }

        // LSHIFT
        public void LSHIFT_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
        }

        public void LSHIFT_KeyUp()
        {
            Co = StartCoroutine(LSHIFT_DelayedKeyUp());
        }

        IEnumerator LSHIFT_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.25f);  
            sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
        }

        IEnumerator LCTRL_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.05f);
            sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
        }
        IEnumerator LCTRL_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.20f);
            sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
        }

        // KEY S
        IEnumerator S_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.10f);
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
        }
        IEnumerator S_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.15f);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
        }

        IEnumerator CoroutineDestructor()
        {
            yield return new WaitForSeconds(0.30f);
            StopAllCoroutines();
        }

        // LSHIFT  + LCTRL + S (SALUTE FOR SUPERCARRIER MODULE)
        public void Salute()
        {
            LSHIFT_KeyDown();
            StartCoroutine(LCTRL_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyUp()); 
            StartCoroutine(LCTRL_DelayedKeyUp());
            StartCoroutine(LSHIFT_DelayedKeyUp());
            StartCoroutine(CoroutineDestructor()); 
        }   
        
        public void SaluteRelease()
        {
            //StopAllCoroutines();
            StartCoroutine(CoroutineDestructor());
            sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
            sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
        }
    }
}


