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

        void Start()
        {
            sim = new InputSimulator();
        }
       
        public void RightMouseUp()
        {
            sim.Mouse.RightButtonUp();
        }

        public void RightMouseDown()
        {
            sim.Mouse.RightButtonDown();
        }

        public void LeftMouseDown()
        {
            sim.Mouse.LeftButtonDown();
        }

        public void LeftMouseUp()
        {
               sim.Mouse.LeftButtonUp();
        }

        /* ----------------------------------------
          * Fx KEYS
          -----------------------------------------*/
        //Press F1
            public void F1_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F1);
            }
            public void F1_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F1);
            }
            public void F1_Press()
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.F1);
            }
            IEnumerator F1_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F1);
            }
            IEnumerator F1_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F1);
            }
        //Press F2
            public void F2_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F2);
            }
            public void F2_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F2);
            }
            public void F2_Press()
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.F2);
            }
            IEnumerator F2_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F2);
            }
            IEnumerator F2_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F2);
            }

        //Press F3
            public void F3_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F3);
            }
            public void F3_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F3);
            }
            IEnumerator F3_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F3);
            }
            IEnumerator F3_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F3);
            }
      
        //Press F4
            public void F4_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F4);
            }
            public void F4_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F4);
            }
            public void F4_Press()
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.F4);
            }
            IEnumerator F4_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F4);
            }
            IEnumerator F4_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F4);
            }

        //Press F5
            public void F5_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F5);
            }
            public void F5_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F5);
            }
            IEnumerator F5_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F5);
            }
            IEnumerator F5_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F5);
            }

        //Press F6
            public void F6_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F6);
            }
            public void F6_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F6);
            }
            IEnumerator F6_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F6);
            }
            IEnumerator F6_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F6);
            }

        //Press F7
            public void F7_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F7);
            }
            public void F7_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F7);
            }
            IEnumerator F7_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F7);
            }
            IEnumerator F7_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F7);
            }

        //Press F8
            public void F8_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F8);
            }
            public void F8_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F8);
            }
            public void F8_Press()
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.F8);
            }
            IEnumerator F8_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F8);
            }
            IEnumerator F8_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F8);
            }

        //Press F9
            public void F9_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F9);
            }
            public void F9_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F9);
            }
            IEnumerator F9_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F9);
            }
            IEnumerator F9_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F9);
            }

        //Press F10
            public void F10_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F10);
            }
            public void F10_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F10);
            }
            IEnumerator F10_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F10);
            }
            IEnumerator F10_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F10);
            }

        //Press F11
            public void F11_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F11);
            }
            public void F11_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F11);
            }
            IEnumerator F11_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F11);
            }
            IEnumerator F11_DelayedKeyUp()

            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F11);
            }

        //Press F12
            public void F12_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.F12);
            }
            public void F12_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.F12);
            }
            IEnumerator F12_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.F12);
            }
            IEnumerator F12_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.F12);
            }

            //Press OEM_5
            public void OEM_5_KeyDown()
            {
                sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
            }
            public void OEM_5_KeyUp()
            {
                sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
            }
            public void OEM_5_KeyPress()
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.OEM_5);
            }
            IEnumerator OEM_5_DelayedKeyDown()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
            }
            IEnumerator OEM_5_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
            }

        //Press LWIN
        public void LWIN_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.LWIN);
        }
        public void LWIN_KeyUp()
        {
            sim.Keyboard.KeyUp(VirtualKeyCode.LWIN);
        }
        public void LWIN_Press()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.LWIN);
        }
        IEnumerator LWIN_DelayedKeyDown()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyDown(VirtualKeyCode.LWIN);
        }

        IEnumerator LWIN_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyUp(VirtualKeyCode.LWIN);
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
        }

        IEnumerator HOME_DelayedKeyUp()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyUp(VirtualKeyCode.HOME);
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
               yield return new WaitForSeconds(0.2f);
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
            }
            IEnumerator RSHIFT_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
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
            }
            IEnumerator LCTRL_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
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
            }
            IEnumerator RCTRL_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);
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
                yield return new WaitForSeconds(0.2f);
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
                yield return new WaitForSeconds(0.2f);
                sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
            }
            IEnumerator S_DelayedKeyUp()
            {
                yield return new WaitForSeconds(0.2f);
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

         /*--------------------------------------------------
         LSHIFT MODIFIED KEYSTROKE
         ------------------------------------------------ */
        // LSHIFT  + U
        public void LSHIFT_U_Press()
        {
            LSHIFT_KeyDown();
            StartCoroutine(U_DelayedKeyDown());
        }

        public void LSHIFT_U_Release()
        {
            U_KeyUp();
            StartCoroutine(LSHIFT_DelayedKeyUp());
            LSHIFT_KeyUp();
        }

        //LWIN + HOME
        public void LWIN_HOME_Press()
        {
            LWIN_KeyDown();
            StartCoroutine(HOME_DelayedKeyDown());
        }

        public void LWIN_HOME_Release()
        {
            HOME_KeyUp();
            StartCoroutine(LWIN_DelayedKeyUp());
        }

      // LCTRL  + E
          public void LCTRL_E_Press()
          {
              LCTRL_KeyDown();
              StartCoroutine(E_DelayedKeyDown());
          }

          public void LCTRL_E_Release()
          {
              E_KeyUp();
              StartCoroutine(LCTRL_DelayedKeyUp());
          }

         public void EjectionCommand()
         {
            for (int i=0; i < 3;i++)
            {
                LCTRL_E_Press();
                LCTRL_E_Release();
            }
         }
    }
}
