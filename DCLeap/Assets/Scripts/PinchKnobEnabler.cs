using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class PinchKnobEnabler : MonoBehaviour
    {
        public KnobScript knob;

        public void KnobEnabler()
        {
            knob.enabled = !knob.enabled;
        }

        public void KnobEnd()
        {
            knob.KnobingEnd();
            knob.enabled = !knob.enabled;
        }
    }
}
