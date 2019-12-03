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
           // freeze.constraintActive = true;            //freeze hand transform movement to avoid parasite knob beahaviour such as increse / decrease when hand go up or down
            knob.enabled = !knob.enabled;
            mouseScript.enabled = !mouseScript.enabled;
        }

        public void KnobEnd()
        {
          //  freeze.constraintActive = false;
            knob.enabled = !knob.enabled;
            mouseScript.enabled = !mouseScript.enabled;
        }
    }
}
