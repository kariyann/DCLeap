using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;

namespace Leap.Unity
{
    public class HandEnabler : MonoBehaviour
    {
        public GameObject HandModel;
        public GameObject RightClickCanvas;
        public GameObject CatShoot;
        public GameObject CatAlign;
        public GameObject StartUp;
        public GameObject Recenter;
        public GameObject Ejection;
        public GameObject Kneeboard;
        public GameObject KneeboardActivator;
        VirtualMouse mouseScript;
        PinchDetector pinchScript;
        ExtendedFingerDetector fingerScript;
        bool MouseVizualizer;
        public GameObject CubeSelector;
        MeshRenderer mesh;
        public Kneeboard kneeboardCommand;
        InputSimulator sim;

        void Start()
        {
            mouseScript = HandModel.GetComponent<VirtualMouse>();
            pinchScript = HandModel.GetComponent<PinchDetector>();
            fingerScript = HandModel.GetComponent<ExtendedFingerDetector>();
            mesh=CubeSelector.GetComponent<MeshRenderer>();
            sim = new InputSimulator();
        }

        IEnumerator RShift_Up()
        {
            yield return new WaitForSeconds(0.5f);
            sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
        }

        IEnumerator CoroutineDestructor()
        {
            yield return new WaitForSeconds(0.6f);
            StopAllCoroutines();
        }

        public void KneeboardEnabler()
        {
            int kneeboard = PlayerPrefs.GetInt("Kneeboard");
            if (kneeboard == 1)                             // enable/disable coordinated with red/green cube visibility to toggle kneeboard if gesture option is ticked in the main menu
               {
                   if (mesh.enabled == true)
                   {
                       Kneeboard.SetActive(true);
                       KneeboardActivator.SetActive(true);
                   }
                   else if (mesh.enabled == false)
                   {
                     Kneeboard.SetActive(false);
                    //KneeboardActivator.SetActive(true);
                   // kneeboardCommand.KneeboardToggle();
                       StartCoroutine(RShift_Up());
                       StartCoroutine(CoroutineDestructor());
                       kneeboardCommand.HideKneeboardCommands();
                   }
               }
        }

        public void Enabler()  // this function is called each time the palm facing gesture is recognized, this allow to enable/disable features 
        {
            /*
             *GET VALUES SAVED BY USER 
             * if user wants to use this kind of gesture, toggles checked in Main Menu = 1,
             */

            int pinch = PlayerPrefs.GetInt("PinchClick");
            int index = PlayerPrefs.GetInt("IndexClick");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int startUp = PlayerPrefs.GetInt("AutoStart");
            int recenter = PlayerPrefs.GetInt("Recenter");
            int ejection = PlayerPrefs.GetInt("Ejection");
            

            mouseScript.enabled = !mouseScript.enabled;   // enable/disable mouse script that control mouse cursor
            mesh.enabled = !mesh.enabled;                 // enable/disable the cube's mesh, allow user to remember cursor state by showing red and green cube

            if(mesh.enabled == false)
            {
                RightClickCanvas.SetActive(false);
            }
            if (mesh.enabled == true)
            {
                RightClickCanvas.SetActive(true);
            }

            if (pinch == 1)                                 // enable/disable pinch only if pinch option is ticked in the main menu
            {
                pinchScript.enabled = !pinchScript.enabled;
            }
            if (pinch == 0)
            {
                pinchScript.enabled = pinchScript.enabled;
            }
            if (index == 1)                                 // enable/disable trigger only if trigger option is ticked in the main menu
            {
                fingerScript.enabled = !fingerScript.enabled;
            }
            if (index == 0)
            {
                fingerScript.enabled = fingerScript.enabled;
            }

            if (catAlign == 1)                             // enable/disable coordinated with red/green cube visibility for thumb's up for catapult alignment only if gesture option is ticked in the main menu
            {
                if (mesh.enabled == true)
                {
                    CatAlign.SetActive(true);
                }
                if (mesh.enabled == false)
                {
                    CatAlign.SetActive(false);
                }
            }

            if (catShoot == 1)                             // enable/disable coordinated with red/green cube visibility for salute to catapult launch only if gesture option is ticked in the main menu
            {
                if (mesh.enabled == true)
                {
                    CatShoot.SetActive(true);
                }
                if (mesh.enabled == false)
                {
                    CatShoot.SetActive(false);
                }
            }

            if (startUp == 1)                             // enable/disable coordinated with red/green cube visibility for index pointing to the sky for automatic startup only if gesture option is ticked in the main menu
            {
                if (mesh.enabled == true)
                {
                    StartUp.SetActive(true);
                }
                if (mesh.enabled == false)
                {
                    StartUp.SetActive(false);
                }
            }

            if (recenter == 1)                            // enable/disable coordinated with red/green cube visibility for front grab for recentering view only if gesture option is ticked in the main menu
            {
                if (mesh.enabled == true)
                {
                    Recenter.SetActive(true);
                }
                if (mesh.enabled == false)
                {
                    Recenter.SetActive(false);
                }
            }

            if (ejection == 1)                             // enable/disable coordinated with red/green cube visibility for ejection only if gesture option is ticked in the main menu
            {
                if (mesh.enabled == true)
                {
                    Ejection.SetActive(true);
                }
                if (mesh.enabled == false)
                {
                    Ejection.SetActive(false);
                }
            }
        }
    }
}
