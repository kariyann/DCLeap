using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class VirtualMouse : MonoBehaviour
    {
        /* ---------------------------------------------------------
         * DEFINITION OF ALL VARIABLES
         * -------------------------------------------------------*/
        public HandModel Hand;

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
         *                             <----------HMD SCREEN RIGHT--=xHMD---->                                      Unity's LeapMotion field of view
         *          <----------HMD SCREEN LEFT-=xHMD---->                                                                    leapTopMargin
         *     (0;0)*-----------------|------------------|-------------------|    ---            (-0.30f;+0.21f) *---------------------------------------                  ---
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     | yHMD       leapLeftMargin   |                 *(0;0)               |leapRightMargin    |deltaY
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     |                             |                                      |                   |
         *          |                 |                  |                   |     |                             |                                      |                   | 
         *          |-----------------|------------------|-------------------*    ---                            ---------------------------------------*(+0.30f;-0.21f)   ---
         *                                                  in this case (2160;1440)                                       leapBottomMargin
         *                                                                                                       <---------------deltaX----------------->
         *        
         *  ------------------------------------------------------------
         *  Explanation about conversion from Unity's leapMotion FoV to HMD Fov
         *  ------------------------------------------------------------
         *  For linear sensivity LinearCalculation():
         *  """""""""""""""""""""""""""""""""""""""""
         *  Cursor position = (cursorPosX;cursorPosY)
         *  cursorPosX = ax * handLeapPosX + bx    where ax is xLinCoef and bx is xOffset     offset is the value to go from (0;0) HMD coordinates system to (0;0) Unity's leapMotion  FoV coordinates system
         *  cursorPosY = ay * handLeapPosY + by    where ay is yLinCoef and by is yOffset
         *  
         * --------------------------------------------------------------------------------------------------------------------------------------------------------------------
         * --------------------------------------- LINEAR APPROACH ------------------------------------------------------------------------------------------------------------
         *  -------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        public float XLinearCalculation()
        {
            float xSensitivity = PlayerPrefs.GetFloat("XSensitivity");
            int xHMD = PlayerPrefs.GetInt("HMD_width");
            float xOffset =  3 * xHMD / 4;
            float deltaX = xSensitivity;
            float xLinCoef = (xHMD / (2.0f)) / (deltaX / 2 );
            float handLeapPosX = Hand.transform.localPosition.x;             // current X position of hand in Unity's LeapMotion field of view
            float cursorPosX = xLinCoef * handLeapPosX + xOffset;
            return cursorPosX;
        }

        public float YLinearCalculation()
        {
            float ySensitivity = PlayerPrefs.GetFloat("YSensitivity");
            int yHMD = PlayerPrefs.GetInt("HMD_height");
            float yOffset = yHMD / 2;
            float deltaY = ySensitivity;
            float yLinCoef = (yHMD / (2.0f)) / (deltaY / 2);
            float handLeapPosY = Hand.transform.localPosition.y;         // current Y position of hand in Unity's LeapMotion field of view
            float cursorPosY = -yLinCoef * handLeapPosY + yOffset;
            return cursorPosY;
        }

        void LinearMouseMouvement()
        {
            float adjustMargin = environmentSet.AdjustMargin();
            float adjustDCS = environmentSet.AdjustDCS();
            float adjustHeight = environmentSet.AdjustHeight();

            if ((int)YLinearCalculation() > adjustHeight)    //if mouse vertical position is greater than DCS bottom
            {
                Win32.SetCursorPos((int)XLinearCalculation(), (int)adjustHeight);
            }

            else if ((int)XLinearCalculation() < adjustMargin)  //if mouse horizontal position is lesser than DCS window left side 
            {
                if ((int)YLinearCalculation() > adjustHeight)  //if mouse vertical position is greater than DCS bottom
                {
                    Win32.SetCursorPos((int)adjustMargin, (int)adjustHeight);   //mouse extreme position will be bottom left corner of DCS window
                }
                Win32.SetCursorPos((int)adjustMargin, (int)YLinearCalculation());    //mouse position will be blocked to its left side but free vertically
            }
            else if
             ((int)XLinearCalculation() > (adjustMargin + adjustDCS))    //if mouse horizontal position is greater than DCS window left side 
            {
                if ((int)YLinearCalculation() > adjustHeight)    //if mouse vertical position is greater than DCS bottom
                {
                    Win32.SetCursorPos((int)(adjustMargin + adjustDCS), (int)adjustHeight);   //mouse extreme position will be bottom right corner of DCS window
                }
                Win32.SetCursorPos((int)(adjustMargin + adjustDCS), (int)YLinearCalculation());   //mouse position will be blocked to its right side but free vertically
            }
            else
            {
                Win32.SetCursorPos((int)XLinearCalculation(), (int)YLinearCalculation());
            }
        }

        void Update()
        {
            LinearMouseMouvement();
        }
    }
}


