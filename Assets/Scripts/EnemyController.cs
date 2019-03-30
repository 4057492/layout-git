using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public GameObject enemy;


	private Animator animator;
	//private Rigidbody rig;

	public int ifDis = 0;
	private int trigger = 0;
	//public Vector3 force = Vector3.zero;

	// Use this for initialization
	void Start () {
		animator = enemy.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (ifDis == 1 && trigger == 0) {
			DisAni ();
			trigger++;
		}

	}

	void DisAni(){
		animator.enabled = false;

	}


}
