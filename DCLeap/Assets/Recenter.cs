using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Recenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.XR.InputTracking.Recenter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
