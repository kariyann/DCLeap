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
        float stored;

        float waitTime;
        float counter = 0.0f;

        void Start()
        {
            sim = new InputSimulator();
            waitTime = PlayerPrefs.GetFloat("Knob sensitivity");
            //waitTime = 0.5f;
            counter = 0;
        }

        public float RollVelocity()
        {
            float rollVelocity = myHand.GetLeapHand().Rotation.z;         //get the hand z-axis rotation position
            //float rollVelocity = transform.rotation.eulerAngles.z;
            return rollVelocity;
        }

       /* public int Knobing()
        {
            int scrollAmount;
            float RollValue = Mathf.Abs(RollVelocity());

            if ((RollValue < 180 && RollValue > 110)|| (RollValue < 350 && RollValue > 300))     // palm commencing counter-clockwise
            {
                scrollAmount = -2;
                return scrollAmount;
            }

            else if ((RollValue < 110 && RollValue > 90)|| (RollValue < 300 && RollValue > 280))     //  palm continue to turn counter clockwise
            {
                scrollAmount = -1;
                return scrollAmount;
            }

            else if ((RollValue < 90 && RollValue > 70) || (RollValue <280 && RollValue > 260))     // neutral palm position (facing floor)
            {
                scrollAmount = 0;
                return scrollAmount;
            }

            else if ((RollValue < 70 && RollValue > 50)||(RollValue < 260 && RollValue > 240))     //  palm continue to turn counter clockwise
            {
                scrollAmount = 1;
                return scrollAmount;
            }

            else if ((RollValue < 50 && RollValue > 0)|| (RollValue < 240 && RollValue > 190))    // palm continue to turn counter clockwise
            {
                scrollAmount = 2;
                return scrollAmount;
            }
            else return 0;
        }*/

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
            if (counter > waitTime)
            {
                Knobing();
                counter = 0;
               // Debug.Log(Knobing());
            }
            else counter += Time.deltaTime;
        }
    }
}