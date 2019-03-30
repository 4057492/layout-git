using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVelocityCon : MonoBehaviour {

	public Vector3 velocity;
	//private Rigidbody rig;

	public GameObject enemy;
	private Rigidbody enemyRig;

	// Use this for initialization
	void Start () {
		//rig = GetComponent<Rigidbody> ();
		enemyRig = enemy.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		enemyRig.velocity = velocity;
	}
}
