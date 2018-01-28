using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestion_balle : MonoBehaviour {
	Vector2 posInit;
	// Use this for initialization
	void Start () {
		posInit = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.tag != "Harpon")
		{
			this.gameObject.transform.position = posInit;
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}
	}

	/*public void SetInitialPosition(Vector3 pos){
		posInit = pos;	
	}*/
}
