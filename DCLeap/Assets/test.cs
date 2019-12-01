using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;



    public class test : MonoBehaviour
    {
        public Quaternion palmRotation;

        // Use this for initialization
        public void Start()
        {
            HandModel hand_model = GetComponent<RiggedHand>();
            Quaternion palmRotation = hand_model.GetPalmRotation();


            //Debug.Log(palmRotation.eulerAngles.z);
        }

        // Update is called once per frame
        void Update()
        {
            
            //Debug.Log(palmRotation.eulerAngles);
        }

        public void Increase()
        {

            Debug.Log(palmRotation.eulerAngles);
        }
    }
