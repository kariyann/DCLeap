using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Leap.Unity
{
    public class PinchSensivityValue : MonoBehaviour
    {
        public Slider PinchSensitivity;
        public TextMeshProUGUI SensitivityValue;

        // Start is called before the first frame update
        void Start()
        {
            float sensitivityValue = PinchSensitivity.value;
            string value = sensitivityValue.ToString("0.00");
            SensitivityValue.text = value;
        }

        void Update()
        {
            float sensitivityValue = PinchSensitivity.value;
            string value = sensitivityValue.ToString("0.00");
            SensitivityValue.text = value;
        }
    }
}
