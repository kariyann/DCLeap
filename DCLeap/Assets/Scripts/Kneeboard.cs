using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;

namespace Leap.Unity
{
    public class Kneeboard : MonoBehaviour
    {
        InputSimulator sim;
        // public GameObject kneeboardPage;
        public GameObject KneeboardCommands;
        public GameObject KneeboardActivator;
        public GameObject LeftHand;
        public GameObject RightHand;
        public GameObject PagesNavigator;
        public GameObject MapBtn;
        public GameObject CockpitBtn;
        int tester =0;


        // Start is called before the first frame update
        void Start()
        {
            sim = new InputSimulator();
            //tester = 0;
        }

        /*-------------------------------------------------------------------------------
         *  DCS Kneeboard Toggle constructor
         * -----------------------------------------------------------------------------*/
        void RShift_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);
        }

        IEnumerator KeyDown_K()
        {
            yield return new WaitForSeconds(0.05f);
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_K);
        }

        IEnumerator KeyUp_K()
        {
            yield return new WaitForSeconds(0.1f);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_K);
        }

        IEnumerator RShift_KeyUp()
        {
            yield return new WaitForSeconds(0.15f);
            sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
        }

        IEnumerator CoroutineDestructor()
        {
            yield return new WaitForSeconds(0.2f);
            StopAllCoroutines();
        }

        public void KneeboardToggle()
        {
            RShift_KeyDown();
            StartCoroutine(KeyDown_K());
            StartCoroutine(KeyUp_K());
            StartCoroutine(RShift_KeyUp());
            StartCoroutine(CoroutineDestructor());
           // PagesNavigator.SetActive(true);
            if (tester == 0)
            {
                PagesNavigator.SetActive(true);
                tester = 1;
            }
            else 
            {
                PagesNavigator.SetActive(false);
                tester = 0;
            }           
        }

        /*-------------------------------------------------------------------------------
         *  VRScratchpad  Toggle constructor
         * -----------------------------------------------------------------------------*/

        void LCTRL_KeyDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
        }

        IEnumerator LShift_KeyDown()
        {
            yield return new WaitForSeconds(0.05f);
            sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
        }

        IEnumerator X_KeyDown()
        {
            yield return new WaitForSeconds(0.1f);
            sim.Keyboard.KeyDown(VirtualKeyCode.VK_X);
        }

        IEnumerator X_KeyUp()
        {
            yield return new WaitForSeconds(0.15f);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_X);
        }

        IEnumerator LShift_KeyUp()
        {
            yield return new WaitForSeconds(0.2f);
            sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
        }

        IEnumerator LCTRL_KeyUp()
        {
            yield return new WaitForSeconds(0.25f);
            sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
        }

        public void VRScratchPadToggle()
        {
            LCTRL_KeyDown();
            StartCoroutine(LShift_KeyDown());
            StartCoroutine(X_KeyDown());
            StartCoroutine(X_KeyUp());
            StartCoroutine(LShift_KeyUp());
            StartCoroutine(LCTRL_KeyUp());
            StartCoroutine(CoroutineDestructor());
        }
        
        /*--------------------------------------------------------------------------
         * DCS KNEEBOARD PAGES NAVIGATION MENU
         * ------------------------------------------------------------------------*/

        public void NextPage()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.NEXT);
        }

        public void PreviousPage()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
        }

        /*--------------------------------------------------------------------------
         * VIEWS SELECTION
         * ------------------------------------------------------------------------*/

        public void MapView()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.F10);
            MapBtn.SetActive(false);
            CockpitBtn.SetActive(true);
            
        }

        public void Cockpit()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.F1);
            CockpitBtn.SetActive(false);
            MapBtn.SetActive(true);
        }

        /*--------------------------------------------------------------------------
         * SHOWING AND UNSHOWING KNEEBOARD CONTROLLER AND CONTROLLING ITS FEATURES
         * ------------------------------------------------------------------------*/
        IEnumerator HideKneeboardCoroutine()
        {
            yield return new WaitForSeconds(0.25f);
            KneeboardActivator.SetActive(true);
            sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
            sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
            StopAllCoroutines();
        }

        public void ShowKneeboardCommands()
        {
            KneeboardCommands.SetActive(true);
            KneeboardActivator.SetActive(false);

            //Now Show Hands to ease interacting with the kneeboard
            LeftHand.layer = LayerMask.NameToLayer("mouseSide");
            RightHand.layer = LayerMask.NameToLayer("mouseSide");

            Transform childrenLeft = LeftHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenLeft)
            {
                go.gameObject.layer = LayerMask.NameToLayer("mouseSide");
            }

            Transform childrenRight = RightHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenRight)
            {
                go.gameObject.layer = LayerMask.NameToLayer("mouseSide");
            }
        }

        public void HideKneeboardCommands()
        {
            KneeboardCommands.SetActive(false);
            //KneeboardActivator.SetActive(true); //----
            StartCoroutine(HideKneeboardCoroutine());

            //Now Hide Hands 
            LeftHand.layer = LayerMask.NameToLayer("Default");
            RightHand.layer = LayerMask.NameToLayer("Default");

            Transform childrenLeft = LeftHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenLeft)
            {
                go.gameObject.layer = LayerMask.NameToLayer("Default");
            }

            Transform childrenRight = RightHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenRight)
            {
                go.gameObject.layer = LayerMask.NameToLayer("Default");
            }
        }

        IEnumerator F8()
        {
            yield return new WaitForSeconds(0.05f);
            sim.Keyboard.KeyPress(VirtualKeyCode.F8);
        }

        IEnumerator F1()
        {
            yield return new WaitForSeconds(0.10f);
            sim.Keyboard.KeyPress(VirtualKeyCode.F1);
        }

        IEnumerator RefuelDestructor()
        {
            yield return new WaitForSeconds(0.15f);
            StopAllCoroutines();
        }

        public void RefuelRearm()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.OEM_5);
            StartCoroutine(F8());
            StartCoroutine(F1());
            StartCoroutine(RefuelDestructor());
        }
    }
}

