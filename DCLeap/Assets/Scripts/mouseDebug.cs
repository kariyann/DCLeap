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
            float cursorPosX = virtualMouse.XLinearCalculation();
            float cursorPosY = virtualMouse.YLinearCalculation();

        }

        // Update is called once per frame
        void Update()
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
