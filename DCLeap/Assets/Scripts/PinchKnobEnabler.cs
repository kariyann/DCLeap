using UnityEngine;

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
            knob.ScrollRelease();  //to reset "counter" if second method is used
            knob.enabled = !knob.enabled;
            mouseScript.enabled = !mouseScript.enabled;
        }
    }
}
