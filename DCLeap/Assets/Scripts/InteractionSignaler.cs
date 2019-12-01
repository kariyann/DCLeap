using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class InteractionSignaler : MonoBehaviour
    {
        public Canvas CatapultShootCanvas;
        private Canvas catapultShootText;
        public Canvas CatAlignCanvas;
        private Canvas catAlignText;

        void Start()
        {
            catapultShootText = CatapultShootCanvas.GetComponent<Canvas>();
            catAlignText = CatAlignCanvas.GetComponent<Canvas>();
        }

        public void CatapultShootTextEnabler()
        {
            catapultShootText.enabled = !catapultShootText.enabled;
        }
        public void CatAlignTextEnabler()
        {
            catAlignText.enabled = !catAlignText.enabled;
        }
    }
}
