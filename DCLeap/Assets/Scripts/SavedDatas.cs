using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Leap.Unity
{
    public class SavedDatas : MonoBehaviour
    {
        public InputField HMDWidth;
        public InputField HMDHeight;

        public Slider XSensitivity;
        float xSensitivity;
        public Slider YSensitivity;
        float ySensitivity;

        public Toggle DebugText;
        int debugTextValue;
        public Toggle DebugMouse;
        int debugMouseValue;

        public Toggle Pinch;
        int pinchValue;
        public Toggle Index;
        int indexValue;
        public Slider PinchSensitivity;
        float sensitivity;
        public Slider KnobSensitivity;
        float knobSensitivity;

        public Toggle CatAlign;
        int catAlignValue;
        public Toggle CatShoot;
        int catShootValue;
        public Toggle Ejection;
        int ejectionValue;
        public Toggle AutoStart;
        int autoStartValue;
        public Toggle Recenter;
        int recenterValue;

        public void Saved()
        {
            /* -----------------------------------------------------------------------------------------------------
             * This part is used to store the values entered in the input fields, storage location is a registry keys you can manually modify in this registry folder (somewhere like : Computer\HKEY_CURRENT_USER\Software\Unity\UnityEditor\Leap4DCS\DCLeap)
            In a first time we will define 2 strings corresponding to the values entered in the input fields
            then we will convert these strings to intergers
            at the end we will store these values in the playerprefs, in the above registry folder
            ----------------------------------------------------------------------------------------------------------------*/


            /* -------------------------------------------------------------------------------------------
             * This part is used to manage the way to perform clicks, index or pinch or implicitly both
             * -------------------------------------------------------------------------------------------*/
            // record the value of pinch if user want to use pinch gesture to perform clicks
            if (Pinch.isOn == true)
            {
                pinchValue = 1;
                PlayerPrefs.SetInt("PinchClick", 1);
            }
            else
            {
                pinchValue = 0;
                PlayerPrefs.SetInt("PinchClick", 0);
            }

            // record the value of index if user want to use index gesture to perform clicks
            if (Index.isOn == true)
            {
                indexValue = 1;
                PlayerPrefs.SetInt("IndexClick", 1);
            }
            else
            {
                indexValue = 0;
                PlayerPrefs.SetInt("IndexClick", 0);
            }


            /*---------------------------------------------------------------------------------------------
             * This part concerns the hands gestures enabled by the user
             * ---------------------------------------------------------------------------------------------*/
            // record the value of catAlign if user want to use thumb up gesture to perform catapult alignment
            if (CatAlign.isOn == true)
            {
                catAlignValue = 1;
                PlayerPrefs.SetInt("CatAlign", 1);
            }
            else
            {
                catAlignValue = 0;
                PlayerPrefs.SetInt("CatAlign", 0);
            }

            // record the value of catShoot if user want to use salute gesture to perform catapult shoot
            if (CatShoot.isOn == true)
            {
                catShootValue = 1;
                PlayerPrefs.SetInt("CatShoot", 1);
            }
            else
            {
                catShootValue = 0;
                PlayerPrefs.SetInt("CatShoot", 0);
            }

            // record the value of ejection if user want to use virtual handlers to perform ejection
            if (Ejection.isOn == true)
            {
                ejectionValue = 1;
                PlayerPrefs.SetInt("Ejection", 1);
            }
            else
            {
                ejectionValue = 0;
                PlayerPrefs.SetInt("Ejection", 0);
            }

            // record the value of Auto start if user want to use index vertical rotating to perform autostart
            if (AutoStart.isOn == true)
            {
                autoStartValue = 1;
                PlayerPrefs.SetInt("AutoStart", 1);
            }
            else
            {
                autoStartValue = 0;
                PlayerPrefs.SetInt("AutoStart", 0);
            }

            // record the value of recenter if user want to use both closed hand to recenter VR view
            if (Recenter.isOn == true)
            {
                recenterValue = 1;
                PlayerPrefs.SetInt("Recenter", 1);
            }
            else
            {
                recenterValue = 0;
                PlayerPrefs.SetInt("Recenter", 0);
            }

            /* ----------------------------------------------------------------------------------------
             * In this section we manage the variables saved in the registry keys in Computer\HKEY_CURRENT_USER\Software\Leap4DCS\DCLeap
             * ---------------------------------------------------------------------------------------*/

            if (DebugText.isOn == true)
            {
                debugTextValue = 1;
                PlayerPrefs.SetInt("DebugText", 1);
            }
            else
            {
                debugTextValue = 0;
                PlayerPrefs.SetInt("DebugText", 0);
            }

            if (DebugMouse.isOn == true)
            {
                debugMouseValue = 1;
                PlayerPrefs.SetInt("DebugMouse", 1);
            }
            else
            {
                debugMouseValue = 0;
                PlayerPrefs.SetInt("DebugMouse", 0);
            }

            xSensitivity = XSensitivity.value;
            PlayerPrefs.SetFloat("XSensitivity", xSensitivity);

            ySensitivity = YSensitivity.value;
            PlayerPrefs.SetFloat("YSensitivity", ySensitivity);

            sensitivity = PinchSensitivity.value;
            PlayerPrefs.SetFloat("Pinch sensitivity", sensitivity);

            knobSensitivity = KnobSensitivity.value;
            PlayerPrefs.SetFloat("Knob sensitivity", knobSensitivity);

            string XHMD = HMDWidth.text;
            string YHMD = HMDHeight.text;

            int xHMD = int.Parse(XHMD);
            int yHMD = int.Parse(YHMD);

            PlayerPrefs.SetInt("HMD_width", xHMD);
            PlayerPrefs.SetInt("HMD_height", yHMD);
        }

        void Start()
        {
            /* --------------------------------------------------------------------------------------------------------------
             * This lines of script will fill the InputFields with stored values of Width and Height and toggle boxes that are used by the user
             * First of all we have to get values stored in the REGISTRY 
             * next we have to convert these integers to strings
             * and finaly fill the Input Fields with these strings
             * -----------------------------------------------------------------------------------------------------------------------*/
            int Width = PlayerPrefs.GetInt("HMD_width");
            int Height = PlayerPrefs.GetInt("HMD_height");
            int debugText = PlayerPrefs.GetInt("DebugText");
            int debugMouse = PlayerPrefs.GetInt("DebugMouse");
            int pinch = PlayerPrefs.GetInt("PinchClick");
            int index = PlayerPrefs.GetInt("IndexClick");
            float xSensitivity = PlayerPrefs.GetFloat("XSensitivity");
            float ySensitivity = PlayerPrefs.GetFloat("YSensitivity");
            float sensitivity = PlayerPrefs.GetFloat("Pinch sensitivity");
            float knobSensitivity = PlayerPrefs.GetFloat("Knob sensitivity");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int ejectionValue = PlayerPrefs.GetInt("Ejection");
            int autoStartValue = PlayerPrefs.GetInt("AutoStart");
            int recenterValue = PlayerPrefs.GetInt("Recenter");

            /*-------------------------------------------------------------------------------------------------------------------------------------
             * Set default values if never saved
             * -------------------------------------------------------------------------------------------------------------------------------------*/
            if (xSensitivity == 0)
            {
                xSensitivity = 0.6f;
            }
            XSensitivity.value = xSensitivity;

            if (ySensitivity == 0)
            {
                ySensitivity = 0.6f;
            }
            YSensitivity.value = ySensitivity;

            if (sensitivity == 0)
            {
                sensitivity = 1.2f;
            }
            PinchSensitivity.value = sensitivity;

            if (knobSensitivity == 0)
            {
                knobSensitivity = 2.0f;
            }
            KnobSensitivity.value = knobSensitivity;

            /*------------------------------------------------------------------------------------------------------------------------------------
             * Set resolutions saved values
             * ----------------------------------------------------------------------------------------------------------------------------------*/
            string StrxHMD = Width.ToString();
            string StryHMD = Height.ToString();

            HMDWidth.placeholder.GetComponent<Text>().text = StrxHMD;
            HMDHeight.placeholder.GetComponent<Text>().text = StryHMD;

            /*-------------------------------------------------------------------------------------------------------------------------------------
             * Set toggle boxes regarding saved data
             * -----------------------------------------------------------------------------------------------------------------------------------*/
            if (debugText == 1)
            {
                DebugText.isOn = true;
            }
            else DebugText.isOn = false;

            if (debugMouse == 1)
            {
                DebugMouse.isOn = true;
            }
            else DebugMouse.isOn = false;

            if (pinch == 1)
            {
                Pinch.isOn = true;
            }
            else Pinch.isOn = false;

            if (index == 1)
            {
                Index.isOn = true;
            }
            else Index.isOn = false;

            if (catAlign == 1)
            {
                CatAlign.isOn = true;
            }
            else CatAlign.isOn = false;

            if (catShoot == 1)
            {
                CatShoot.isOn = true;
            }
            else CatShoot.isOn = false;

            if (ejectionValue == 1)
            {
                Ejection.isOn = true;
            }
            else Ejection.isOn = false;

            if (autoStartValue == 1)
            {
                AutoStart.isOn = true;
            }
            else AutoStart.isOn = false;

            if (recenterValue == 1)
            {
                Recenter.isOn = true;
            }
            else Recenter.isOn = false;
        }
    }
}
