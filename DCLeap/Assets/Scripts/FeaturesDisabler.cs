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

        /*******************************************
         * ALLOW FEATURES MANAGEMENT
         * Get playersprefs values and if these are null, feature is not launched in DCLeap scene
         *******************************************/

        void Start()
        {
            int debugText = PlayerPrefs.GetInt("DebugText");
            int debugMouse = PlayerPrefs.GetInt("DebugMouse");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int autoStartValue = PlayerPrefs.GetInt("AutoStart");
            int recenterValue = PlayerPrefs.GetInt("Recenter");
            int ejection = PlayerPrefs.GetInt("Ejection");

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

            if (debugMouse == 0)
            {
                RHDebugMouse.SetActive(false);
            }

            if (debugMouse == 0)
            {
                LHDebugMouse.SetActive(false);
            }

            if (ejection == 0)
            {
                Ejection.SetActive(false);
            }
        }

    }
}
