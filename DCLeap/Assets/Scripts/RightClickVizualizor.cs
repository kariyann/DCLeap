using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{

    public class RightClickVizualizor : MonoBehaviour
    {
        public GameObject BlueCube;
        MeshRenderer mesh;

        void Start()
        {
            mesh = BlueCube.GetComponent<MeshRenderer>();
        }

        public void TextEnabler()            //Text beacuse of legacy version, text has been replaced by a blue cube
        {
            mesh.enabled = !mesh.enabled;
        }
    }
}
