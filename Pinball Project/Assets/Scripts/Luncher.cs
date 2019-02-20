using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luncher : MonoBehaviour {

    public string button = "Luncher";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton(button)){
			this.GetComponent<ConstantForce>().enabled = true;	
		} else {
			this.GetComponent<ConstantForce>().enabled = false;
		}
	}
}
