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
        public InputSimulator sim;

        float waitTime;
        float counter = 0.0f;

        float previous;
        float sensibility;

        private void Start()
        {
            previous = 0.0f;
            sensibility = PlayerPrefs.GetFloat("Knob sensitivity");
            waitTime = 0.1f;
            counter = 0.0f;
            sim = new InputSimulator();
        }

        void Scroll()
        {
            float last = myHand.GetLeapHand().PalmNormal.Roll;
            float rollVelocity = (last - previous) / Time.deltaTime;
            previous = last;
            int amount = -(int)(rollVelocity * (1-sensibility));

            if (counter > waitTime)
            {
                sim.Mouse.VerticalScroll(amount);
                counter = 0;
                Debug.Log(amount);
            }
            else counter += Time.deltaTime;
        }

        void Update()
        {
            Scroll();
        }
    }
}