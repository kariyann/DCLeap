using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

namespace Leap.Unity
{
    public class PinchKnobEnabler : MonoBehaviour
    {
        public KnobScript knob;
        public VirtualMouse mouseScript;

        public void KnobEnabler()
        {
            knob.enabled = !knob.enabled;
            mouseScript.enabled = !mouseScript.enabled;
        }

        public void KnobEnd()
        {
            knob.enabled = !knob.enabled;
            mouseScript.enabled = !mouseScript.enabled;
        }
    }
}
