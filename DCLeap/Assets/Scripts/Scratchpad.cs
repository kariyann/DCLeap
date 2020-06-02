using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Leap.Unity
{
    public class Scratchpad : MonoBehaviour
    {
        public TextMeshProUGUI scratchPad;
        // Start is called before the first frame update
        void Start()
        {
            scratchPad.text = "No notes \n in scratchpad \n Open virtual keyboard to \n type text";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

