using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{

    public class RightClickVizualizor : MonoBehaviour
    {
       // public Canvas TextContener;
      //  private Canvas rightClickText;
        public GameObject BlueCube;
        MeshRenderer mesh;

        void Start()
        {
            mesh = BlueCube.GetComponent<MeshRenderer>();
        //    rightClickText = TextContener.GetComponent<Canvas>();
        }

        public void TextEnabler()
        {
            mesh.enabled = !mesh.enabled;
          //  rightClickText.enabled = !rightClickText.enabled;
        }
    }
}
