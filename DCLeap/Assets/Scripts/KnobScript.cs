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
        float updateCounter = 0.0f;

        float lhNeutral;
        float rhNeutral ;

        private void Start()
        {
            lhNeutral = PlayerPrefs.GetFloat("LH Neutral");
            rhNeutral = PlayerPrefs.GetFloat("RH Neutral");
            waitTime = 0.1f;
            counter = 0.0f;
            sim = new InputSimulator();
        }

        void SecondScrollMethod()
        {
            int amount;

            //LEFT HAND
            if (myHand.GetLeapHand().IsLeft == true)
            {
                if (myHand.GetLeapHand().PalmNormal.Roll > (lhNeutral+0.15)) //1.05
                {
                    amount = -1 * CounterFactor() ;
                }
                else if (myHand.GetLeapHand().PalmNormal.Roll < (lhNeutral - 0.15))  //0.90
                {
                    amount = 1 * CounterFactor();
                }
                else amount = 0;

                sim.Mouse.VerticalScroll(amount);
            }

            // RIGHT HAND
            else
            {
                if (myHand.GetLeapHand().PalmNormal.Roll > (rhNeutral + 0.15))  //-0.65
                {
                    amount = -1 * CounterFactor();
                }
                else if (myHand.GetLeapHand().PalmNormal.Roll < (rhNeutral - 0.15))  //-0.95
                {
                    amount = 1 * CounterFactor();
                }
                else amount = 0;

                sim.Mouse.VerticalScroll(amount);
            }
            Debug.Log(amount);
        }

        public int CounterFactor()
        {
            int factor = 0;

            if (counter >0.0f && counter < 2.0f)
            {
                factor = 1;
            }

            if (counter > 2.0f && counter <3.0f)
            {
                factor = 2;
            }

            if (counter > 3.0f && counter < 4.0f)
            {
                factor = 4;
            }

            if (counter > 4.0f)
            {
                factor = 8;
            }

            return factor;
        }

        public void ScrollRelease()
        {
            counter = 0;
            updateCounter = 0.0f;
        }

        void Update()
        {
           if (updateCounter > waitTime * 5)
           {
                SecondScrollMethod();
                updateCounter = 0.0f;
           }
            counter += Time.deltaTime;
            updateCounter += Time.deltaTime;
        }
    }
}