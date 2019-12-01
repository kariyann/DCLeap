using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class MouseSleep : MonoBehaviour
    {
        public VirtualMouse mouseScript;
        public GameObject CubeSelector;
        MeshRenderer mesh;

        void Start()
        {
            mesh = CubeSelector.GetComponent<MeshRenderer>();  //get the mes renderer in order to verify condition line 28
        }

        public void Sleep()
        {
            if (mouseScript.isActiveAndEnabled == true)
            {
                mouseScript.enabled = !mouseScript.enabled;            // if virtual mouse script is enable at knob start or trigger start, this disable virtual mouse so cursor will stay in position during "knobing" or triggering
            }
        }

        public void Wake()
        {
            if (mouseScript.isActiveAndEnabled == false && mesh.isVisible == true)
            {
                mouseScript.enabled = !mouseScript.enabled;      // re-enable virtual mouse if virtual mouse were disabled and virtual hand was enabled (green / red cube)
            }
        }
    }
}
