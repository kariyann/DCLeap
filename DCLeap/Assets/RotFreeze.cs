using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class RotFreeze : MonoBehaviour {
    Quaternion rotation;
    Vector3 position;

    // Use this for initialization
    void Start () {

        rotation = transform.rotation;
        position = transform.position;
       


	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = rotation;
        transform.position = position;
	}
}
