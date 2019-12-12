using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Leap.Unity
{
    public class PinchActivationSensivityValue : MonoBehaviour
    {
        public Slider ActivationSensitivity;
        public TextMeshProUGUI activationSensitivityValue;

        // Start is called before the first frame update
        void Start()
        {
            float sensitivityValue = ActivationSensitivity.value;
            string value = sensitivityValue.ToString("0.000");
           activationSensitivityValue.text = value;
        }

        void Update()
        {
            float sensitivityValue = ActivationSensitivity.value;
            string value = sensitivityValue.ToString("0.000");
            activationSensitivityValue.text = value;
        }
    }
}
