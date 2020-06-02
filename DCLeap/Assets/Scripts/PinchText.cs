using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class PinchText : MonoBehaviour
    {
        public Canvas PinchCanvas;
        private Canvas pinchText;
        public Canvas TriggerCanvas;
        private Canvas triggerText;

        void Start()
        {
            pinchText = PinchCanvas.GetComponent<Canvas>();
            triggerText = TriggerCanvas.GetComponent<Canvas>();
        }

        public void PinchTextEnabler()
        {
            pinchText.enabled = !pinchText.enabled;
        }

        public void TriggerTextEnabler()
        {
            triggerText.enabled = !triggerText.enabled;
        }
    }
}