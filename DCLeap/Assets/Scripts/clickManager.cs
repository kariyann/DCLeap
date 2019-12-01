using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*---------------------------------------------------------------------------------------------------
 * Check click method desired by user when start 
 * --------------------------------------------------------------------------------------------------*/

namespace Leap.Unity
{
    public class clickManager : MonoBehaviour
    {
        public PinchDetector pinchDetector;
        public ExtendedFingerDetector extendedFinger;
            
        public void Pinch()
        {
            int pinch = PlayerPrefs.GetInt("PinchClick");
            if (pinch == 1)
            {
                pinchDetector.enabled = !pinchDetector.enabled;
            }
        }

        public void Index()
        {
            int index = PlayerPrefs.GetInt("IndexClick");
            if (index == 1)
            {
                extendedFinger.enabled = !extendedFinger.enabled;
            }
        }

        void Start()
        {
            Pinch();
            Index();
        }
    }
}
