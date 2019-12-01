using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Leap.Unity
{
    public class mouseDebug : MonoBehaviour
    {
        public Canvas mouseCanvas;
        public VirtualMouse virtualMouse;
        public TextMeshProUGUI mouseX;
        public TextMeshProUGUI mouseY;

        // Start is called before the first frame update
        void Start()
        {
            float cursorPosX = virtualMouse.XLinearCalculation();   // get X coordinates from VirtualMouse.cs
            float cursorPosY = virtualMouse.YLinearCalculation();   // get Y coordinates from VirtualMouse.cs

        }

        // Update is called once per frame
        void Update()    // convert coordinates from VirtualMouse.cs to string format in order to be shown in the debug text.box shown in the HMD (if debug is allowed in main menu
        {
            int cursorPosX = (int)virtualMouse.XLinearCalculation();
            int cursorPosY = (int)virtualMouse.YLinearCalculation();
            string valueX = cursorPosX.ToString("0");
            string valueY = cursorPosY.ToString("0");
            mouseX.text = valueX;
            mouseY.text = valueY;
        }
    }
}
