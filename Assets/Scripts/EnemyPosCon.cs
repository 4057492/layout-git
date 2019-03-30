using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosCon : MonoBehaviour {

	public GameObject posCon;

	private Rigidbody rig;
	private Rigidbody otherRig;

	public Vector3 force;

	void Start(){
		rig = GetComponent<Rigidbody> ();
		otherRig = posCon.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		rig.velocity = otherRig.velocity;
	}

	public void AddAForce(){
		otherRig.AddForce(force);
	}
}
