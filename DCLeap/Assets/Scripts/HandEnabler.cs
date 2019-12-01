using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        VirtualMouse mouseScript;
        PinchDetector pinchScript;
        ExtendedFingerDetector fingerScript;
        bool MouseVizualizer;
        public GameObject CubeSelector;
        MeshRenderer mesh;

        void Start()
        {
            mouseScript = HandModel.GetComponent<VirtualMouse>();
            pinchScript = HandModel.GetComponent<PinchDetector>();
            fingerScript = HandModel.GetComponent<ExtendedFingerDetector>();
            mesh=CubeSelector.GetComponent<MeshRenderer>();
        }

        public void Enabler()
        {
            int pinch = PlayerPrefs.GetInt("PinchClick");
            int index = PlayerPrefs.GetInt("IndexClick");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int startUp = PlayerPrefs.GetInt("AutoStart");
            int recenter = PlayerPrefs.GetInt("Recenter");
            int ejection = PlayerPrefs.GetInt("Ejection");

            mouseScript.enabled = !mouseScript.enabled;
           // MouseVizualizer = !MouseVizualizer;
            mesh.enabled = !mesh.enabled;

            if(mesh.enabled == false)
            {
                RightClickCanvas.SetActive(false);
            }
            if (mesh.enabled == true)
            {
                RightClickCanvas.SetActive(true);
            }

            if (pinch == 1)
            {
                pinchScript.enabled = !pinchScript.enabled;
            }
            if (pinch == 0)
            {
                pinchScript.enabled = pinchScript.enabled;
            }
            if (index == 1)
            {
                fingerScript.enabled = !fingerScript.enabled;
            }
            if (index == 0)
            {
                fingerScript.enabled = fingerScript.enabled;
            }

            if (catAlign == 1)
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

            if (catShoot == 1)
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

            if (startUp == 1)
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

            if (recenter == 1)
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

            if (ejection == 1)
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
