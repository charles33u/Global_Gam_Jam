using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour {
	public GameObject projectile;
	private int compteur=0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (projectile.GetComponent<Rigidbody2D> ().velocity==Vector2.zero) {
			projectile.GetComponent<Rigidbody2D> ().AddForce (transform.forward * 10);
		}
	}


}
