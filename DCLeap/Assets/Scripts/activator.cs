using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

namespace Leap.Unity {
   public class activator : MonoBehaviour
    {
        private PalmDirectionDetector palmDirectionDetector;
        private PinchDetector pinchDetector;
        private ExtendedFingerDetector extendedDetector;
        public InputSimulator sim;
       // VirtualMouse mouseScript; 171

        int pinchOn;
        int indexOn;

        void Start()
        {
            palmDirectionDetector = GetComponent<PalmDirectionDetector>();
            pinchDetector = GetComponent<PinchDetector>();
            extendedDetector = GetComponent<ExtendedFingerDetector>();
            sim = new InputSimulator();
            int pinchOn = PlayerPrefs.GetInt("PinchClick");
            int indexOn = PlayerPrefs.GetInt("IndexClick");
        }

        public void PinchClickTypeSelectionDown()
        {
           // if (palmDirectionDetector.IsActive == false && indexOn == 1)     // if palm is not facing the helmet execute leftclick with pinch gesture
                if (palmDirectionDetector.IsActive == false)
                {
                //extendedDetector.enabled = !extendedDetector.enabled;
                sim.Mouse.LeftButtonDown();

            }

           // if (palmDirectionDetector.IsActive == true && indexOn == 1)        // if palm is facing the helmet execute rightclick with pinch gesture
                if (palmDirectionDetector.IsActive == true )
                {
               // extendedDetector.enabled = !extendedDetector.enabled;
                sim.Mouse.RightButtonDown();
            }
        }

        public void PinchClickTypeSelectionUp()
        {
            //if (palmDirectionDetector.IsActive == false && indexOn == 1)
                if (palmDirectionDetector.IsActive == false )
                {
                sim.Mouse.LeftButtonUp();                     // force button up to avoid parasite comportements if button is "seen" down by Windows after executing PinchClickTypeSelectionDown()
               // sim.Mouse.RightButtonUp();
               // extendedDetector.enabled = !extendedDetector.enabled;
            }

           // if (palmDirectionDetector.IsActive == true && indexOn == 1)
                if (palmDirectionDetector.IsActive == true )
                {
                sim.Mouse.RightButtonUp();                  // force button up to avoid parasite comportements if button is "seen" down by Windows after executing PinchClickTypeSelectionDown()
               // sim.Mouse.LeftButtonUp();
                //extendedDetector.enabled = !extendedDetector.enabled;
            }
        }

        public void IndexClickTypeSelectionDown()
        {
            //if (palmDirectionDetector.IsActive == false && pinchOn == 1)         // if palm is not facing the helmet execute leftclick with trigger gesture
                if (palmDirectionDetector.IsActive == false)
                {
              // pinchDetector.enabled = !pinchDetector.enabled;
                sim.Mouse.LeftButtonDown();
            }

           // if (palmDirectionDetector.IsActive == true && pinchOn == 1)
                if (palmDirectionDetector.IsActive == true )         // if palm is facing the helmet execute rightclick with trigger gesture
            {
               // pinchDetector.enabled = !pinchDetector.enabled;
                sim.Mouse.RightButtonDown();
            }
        }

        public void IndexClickTypeSelectionUp()
        {
           // if (palmDirectionDetector.IsActive == false && pinchOn == 1)
                if (palmDirectionDetector.IsActive == false )
                {
                sim.Mouse.LeftButtonUp();
               // pinchDetector.enabled = !pinchDetector.enabled;
            }

           // if (palmDirectionDetector.IsActive == true && pinchOn == 1)
                if (palmDirectionDetector.IsActive == true)
                {
                sim.Mouse.RightButtonUp();
              //  pinchDetector.enabled = !pinchDetector.enabled;
            }
        }
    }
 }