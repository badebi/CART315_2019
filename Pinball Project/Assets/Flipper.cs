using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

public string button = "leftFlipper";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton(button)){
			this.GetComponent<HingeJoint>().useMotor = true;	
		} else {
			this.GetComponent<HingeJoint>().useMotor = false;
		}
	}
}
