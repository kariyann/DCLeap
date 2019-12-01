using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

namespace Leap.Unity
{
    public class KnobScript : MonoBehaviour
    {
        public HandModel myHand;
        public KeyStroke keystroke;
        public VirtualMouse mouseScript;
        public InputSimulator sim;
        Coroutine co;
        float stored;

        void Start()
        {
            sim = new InputSimulator();
            float stored = RollVelocity();
        }

        public float RollVelocity()
        {
            float rollVelocity = myHand.GetLeapHand().Rotation.z;     //get the hand z-axis rotation position
            return rollVelocity;
        }

        public void Knobing()
        {
            float knobSensitivity = PlayerPrefs.GetFloat("Knob sensitivity");
            float deltaf = (RollVelocity() - stored) * 100 * knobSensitivity;         // this calculate the angular velocity needed to determine how many "scroll clicks"
            stored = RollVelocity();                             
            int delta = (int)deltaf;
            sim.Mouse.VerticalScroll(delta);    // execute mouse scroll for an amount of "delta" clicks
        }

        void Update()
        {
            Knobing();  // this one is used as update method in pinch OnActivate() script to perform knob rotation as long as pinch is maintained
        }
    }
}