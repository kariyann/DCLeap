using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

/*---------------------------------------------------------------------------------------------------------------
 * Set User32.dll to allow mouse control
 * Set Margin to avoid mouse to be outside DCS VR window
 * -----------------------------------------------------------------------------------------------------------------*/

namespace Leap.Unity
{
    public class Win32
    {
        
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);


        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
    
    public class environmentSet : MonoBehaviour
    {
        public static float AdjustMargin()  //get left and right margin of the VR DCS windows in order to not allowed mouse to go out
        {
            float adjustMargin = Screen.currentResolution.width * 0.23f;
            return adjustMargin;
        }

        public static float AdjustDCS()  //get  DCS window's width in order to allow mouse only inside it
        {
            float adjustDCS = Screen.currentResolution.width * 0.53f;
            return adjustDCS;
        }

        public static float AdjustHeight()  //get DCS window's height in order to avoid mouse to go in taskbar 
        {
            float adjustHeight = Screen.currentResolution.height * 0.90f;
            return adjustHeight;
        }

        void Start()
        {
            AdjustMargin();
            AdjustDCS();
            AdjustHeight();
        }
    }
}
