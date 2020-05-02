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

      /*  IEnumerator LSHIFT_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
        }*/
        IEnumerator LSHIFT_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.5f);  //***************
            sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
        }

            // LCTRL
      /*  public void LCTRL_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
        }
        public void LCTRL_KeyUp()
        {
            sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
        }*/
        IEnumerator LCTRL_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.1f);
            sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
        }
        IEnumerator LCTRL_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.4f);
            sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
        }

        // KEY S
      /*  public void S_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
        }
        public void S_KeyUp()
        {
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
        }*/
        IEnumerator S_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
        }
        IEnumerator S_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.3f);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
        }

        IEnumerator CoroutineDestructor()
        {
            yield return new WaitForSeconds(0.6f);
            StopAllCoroutines();
        }

        // LSHIFT  + LCTRL + S (SALUTE FOR SUPERCARRIER MODULE)
        public void Salute()
        {
            LSHIFT_KeyDown();
            StartCoroutine(LCTRL_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyUp()); // ******
            StartCoroutine(LCTRL_DelayedKeyUp());
            StartCoroutine(LSHIFT_DelayedKeyUp());  // ********
            StartCoroutine(CoroutineDestructor());  //*********/
        }   
        
        public void SaluteRelease()
        {
            StopAllCoroutines();
            sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
            sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
        }
    }
}


