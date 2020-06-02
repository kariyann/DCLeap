using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class FeaturesDisabler : MonoBehaviour
    {
        public GameObject CatShooter;
        public GameObject CatAligner;
        public GameObject AutoStart;
        public GameObject Recenter;
        public GameObject RHDebugMouse;
        public GameObject LHDebugMouse;
        public GameObject CatShootCanvas;
        public GameObject CatAlignCanvas;
        public GameObject EjectionKnees;
        public GameObject EjectionOverhead;
        public GameObject Ejection;
        public GameObject Kneeboard;
        public GameObject PinchText;
        public GameObject TriggerText;

        public GameObject LeftHand;
        public GameObject RightHand;

        /*******************************************
         * ALLOW FEATURES MANAGEMENT
         * Get playersprefs values and if these are null, feature is not launched in DCLeap scene
         *******************************************/

        void Start()
        {
            int showHands = PlayerPrefs.GetInt("Show Hands");
            int debugText = PlayerPrefs.GetInt("DebugText");
            int debugMouse = PlayerPrefs.GetInt("DebugMouse");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int autoStartValue = PlayerPrefs.GetInt("AutoStart");
            int recenterValue = PlayerPrefs.GetInt("Recenter");
            int ejection = PlayerPrefs.GetInt("Ejection");
            int kneeboard = PlayerPrefs.GetInt("Kneeboard");

            if (showHands == 1)    // if you want to show your hands, the playerprefs value stored is 1, so this function change the hands's layer to be shown in the overlay
            {
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

            if (catShoot == 0)
            {
                CatShooter.SetActive(false);
            }

            if (catAlign == 0)
            {
                CatAligner.SetActive(false);
            }

            if (autoStartValue == 0)
            {
                AutoStart.SetActive(false);
            }

            if (recenterValue == 0)
            {
                Recenter.SetActive(false);
            }


            if (debugText == 0)
            {
                CatShootCanvas.SetActive(false);
                CatAlignCanvas.SetActive(false);
                EjectionKnees.SetActive(false);
                EjectionOverhead.SetActive(false);
            }

          /*  if (debugMouse == 0)
            {
                RHDebugMouse.SetActive(false);
            }

            if (debugMouse == 0)
            {
                LHDebugMouse.SetActive(false);
            }*/

            if (debugMouse == 0)
            {
                PinchText.SetActive(false);
                TriggerText.SetActive(false);
                RHDebugMouse.SetActive(false);
                LHDebugMouse.SetActive(false);
            }

            if (ejection == 0)
            {
                Ejection.SetActive(false);
            }
            if (kneeboard == 0)
            {
                Kneeboard.SetActive(false);
            }
        }

    }
}
