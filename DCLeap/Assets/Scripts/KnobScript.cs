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
        public MouseSleep mouseSleep;
        public InputSimulator sim;
      //  public GameObject CubeSelector;
       // MeshRenderer mesh;
        Coroutine co;
        float stored;

        void Start()
        {
            sim = new InputSimulator();
          //  mesh = CubeSelector.GetComponent<MeshRenderer>();  //get the mes renderer in order to verify condition line 47
            float stored = RollVelocity();
        }

        public float RollVelocity()
        {
            float rollVelocity = myHand.GetLeapHand().Rotation.z;     //get the hand z-axis rotation position
            return rollVelocity;
        }

        public void Knobing()
        {
          //  mouseSleep.Sleep();
           /* if (mouseScript.isActiveAndEnabled == true)
            {
                mouseScript.enabled = !mouseScript.enabled;            // if virtual mouse script is enable at knob start, this disable virtual mouse so cursor will stay in position during "knobing"
            }*/
            float knobSensitivity = PlayerPrefs.GetFloat("Knob sensitivity");
            float deltaf = (RollVelocity() - stored) * 100 * knobSensitivity;         // this calculate the angular velocity needed to determine how many "scroll clicks"
            stored = RollVelocity();                             
            int delta = (int)deltaf;
            sim.Mouse.VerticalScroll(delta);    // execute mouse scroll for an amount of "delta" clicks
        }

         public void KnobingEnd()
         {
           // mouseSleep.Wake();
            /*if (mouseScript.isActiveAndEnabled == false  && mesh.isVisible == true)
            {
                mouseScript.enabled = !mouseScript.enabled;      // re-enable virtual mouse if virtual mouse were disabled and virtual hand was enabled (green / red cube)
            }*/
        }

        void Update()
        {
            Knobing();  // this one is used as update method in pinch OnActivate() script to perform knob rotation as long as pinch is maintained
        }
    }
}