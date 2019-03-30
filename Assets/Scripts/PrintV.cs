using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintV : MonoBehaviour {

	private Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		print (rig.velocity);
	}
}
