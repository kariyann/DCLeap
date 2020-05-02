using WindowsInput.Native;
using System.Collections;
using WindowsInput;
//using Leap.Unity.Interaction;
using UnityEngine;
namespace Leap.Unity
{
  //  [RequireComponent(typeof(InteractionButton))]

/* first of all, I don't know why but in order to get letter keystroke works in DCS with LeapMotion, I had to create 2 functions, 1 KeyDown and 1KeyUp.
    These are called by Unity with the Interaction Behaviour scripts of leapMotion attached to the press buttons.
    The KeyDown function is called in the OnPress() function of the Behaviour script, while the KeyUp is called in the OnRelease() function of the Behaviour script.

    Concerning others keystroke (numbers, enter, delete and others) the KeyPress is working so there is only one function. This one is called only in the OnPress() function of the Behaviour script in unity.
*/

    public class KeyStroke : MonoBehaviour
    {
        InputSimulator sim;
        Coroutine Co;
        float waitTime;
        float counter;

        void Start()
        {
            sim = new InputSimulator();
            counter = 0.0f;
            waitTime = 0.1f;
        }

        //Press HOME
        public void HOME_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.HOME);
        }
        public void HOME_KeyUp()
        {
            sim.Keyboard.KeyUp(VirtualKeyCode.HOME);
        }
         public void HOME_Press()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
        }

        IEnumerator HOME_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyDown(VirtualKeyCode.HOME);
            StopAllCoroutines();    //**
        }

        IEnumerator HOME_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyUp(VirtualKeyCode.HOME);
            StopAllCoroutines();    //**
        }

        /* ----------------------------------------
          * MODIFIERS KEYS
          -----------------------------------------*/
        // LSHIFT
            public void LSHIFT_KeyDown()
            {
               sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            }

            public void LSHIFT_KeyUp()
            {
            Co = StartCoroutine(LSHIFT_DelayedKeyUp());
            }

            IEnumerator LSHIFT_DelayedKeyDown()
            {
               yield return new WaitForSeconds(0.2f);
               sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            }
            IEnumerator LSHIFT_DelayedKeyUp()
            {
               yield return new WaitForSeconds(1.0f);  //***************
               sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
            }
        
        // RSHIFT
            public void RSHIFT_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);
            }
            public void RSHIFT_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
            }

            IEnumerator RSHIFT_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);
                StopAllCoroutines();    //**
            }
            IEnumerator RSHIFT_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
                StopAllCoroutines();    //**
            }

        // LCTRL
            public void LCTRL_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
            }
            public void LCTRL_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
            }
            IEnumerator LCTRL_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
                //StopAllCoroutines();    //**
            }
            IEnumerator LCTRL_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.8f);
                sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
                //StopAllCoroutines();    //**
            }
        

        // RCTRL
            public void RCTRL_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);
            }

            public void RCTRL_KeyUp()
            {
                Co = StartCoroutine(RCTRL_DelayedKeyUp());
            }
            IEnumerator RCTRL_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);
                StopAllCoroutines();    //**
            }
            IEnumerator RCTRL_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);
                StopAllCoroutines();    //**
            }

            // ESCAPE
            public void ESCAPE_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.ESCAPE);
            }
            public void ESCAPE_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.ESCAPE);
            }
            IEnumerator ESCAPE_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.ESCAPE);
            }
            IEnumerator ESCAPE_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.ESCAPE);
            }

       // KEY E
           public void E_KeyDown()
           {
               sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
           }
           public void E_KeyUp()
           {
               sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
           }
           IEnumerator E_DelayedKeyDown()
           {
               yield return new WaitForSeconds(0.2f);
               sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
           }
           IEnumerator E_DelayedKeyUp()
           {
               yield return new WaitForSeconds(0.2f);
               sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
           }

        // KEY U
        public void U_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
                StartCoroutine(U_DelayedKeyUp());
            }
            public void U_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
            }
            IEnumerator U_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
            }
            IEnumerator U_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.1f);  //****************************
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
            }
 
        // KEY S
            public void S_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
            }
            public void S_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
            }
            IEnumerator S_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.4f);
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
            }
            IEnumerator S_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.6f);
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
            }
        


        // KEY L
            public void L_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_L);
            }
            public void L_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_L);
            }
            IEnumerator L_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_L);
            }
            IEnumerator L_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.VK_L);
            }
            
            IEnumerator CoroutineDestructor()
            {
                yield return new WaitForSeconds(1.2f);
               StopAllCoroutines();
            }

         /*--------------------------------------------------
         LSHIFT MODIFIED KEYSTROKE
         ------------------------------------------------ */

        // LSHIFT  + LCTRL + S (SALUTE FOR SUPERCARRIER MODULE)
        public void Catapult()
        {
            LSHIFT_KeyDown();
            StartCoroutine(LCTRL_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyDown());
            StartCoroutine(S_DelayedKeyUp()); // ******
            StartCoroutine(LCTRL_DelayedKeyUp());
            StartCoroutine(LSHIFT_DelayedKeyUp());  // ********
            StartCoroutine(CoroutineDestructor());  //*********/
        }

        public void EjectionCommand()
        {
            int execution = 0;
            float waitTime = 0.2f;
            float counter = 0.0f;

            sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);

            while (execution < 3)
            {
                if (counter > waitTime)
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);
                    counter = 0;
                    execution++;
                }
                else counter += Time.deltaTime;
            }

            sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
        }
    }
}
