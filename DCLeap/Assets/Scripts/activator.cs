using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

namespace Leap.Unity {
   public class activator : MonoBehaviour
    {
        private PalmDirectionDetector palmDirectionDetector;
        private PinchDetector pinchDetector;
        public InputSimulator sim;
        VirtualMouse mouseScript;
        Coroutine co;

        void Start()
        {
            palmDirectionDetector = GetComponent<PalmDirectionDetector>();
            pinchDetector = GetComponent<PinchDetector>();
            sim = new InputSimulator();
        }

        public void PinchClickTypeSelectionDown()
        {
            if (palmDirectionDetector.IsActive == false)     // if palm is not facing the helmet execute leftclick with pinch gesture
            {
                sim.Mouse.LeftButtonDown();
            }

            if (palmDirectionDetector.IsActive == true)        // if palm is facing the helmet execute rightclick with pinch gesture
            {
                sim.Mouse.RightButtonDown();
            }
        }

        public void PinchClickTypeSelectionUp()
        {
            if (palmDirectionDetector.IsActive == false)
            {
                sim.Mouse.LeftButtonUp();                     // force button up to avoid parasite comportements if button is "seen" down by Windows after executing PinchClickTypeSelectionDown()
                sim.Mouse.RightButtonUp();
            }

            if (palmDirectionDetector.IsActive == true)
            {
                sim.Mouse.RightButtonUp();                  // force button up to avoid parasite comportements if button is "seen" down by Windows after executing PinchClickTypeSelectionDown()
                sim.Mouse.LeftButtonUp();
            }
        }

        public void IndexClickTypeSelectionDown()
        {
            if (palmDirectionDetector.IsActive == false)         // if palm is not facing the helmet execute leftclick with trigger gesture
            {
                sim.Mouse.LeftButtonDown();
            }

            if (palmDirectionDetector.IsActive == true)         // if palm is facing the helmet execute rightclick with trigger gesture
            {
                sim.Mouse.RightButtonDown();
            }
        }

        public void IndexClickTypeSelectionUp()
        {
            if (palmDirectionDetector.IsActive == false)
            {
                sim.Mouse.LeftButtonUp();                              
            }

            if (palmDirectionDetector.IsActive == true)
            {
                sim.Mouse.RightButtonUp();
            }
        }
    }
 }