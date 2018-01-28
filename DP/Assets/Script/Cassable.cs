using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassable : MonoBehaviour {

	private float timer = 0f;
	private bool hasBeenSteppedOn = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasBeenSteppedOn)
			return;
		timer += Time.deltaTime;
		if (timer >= .5f)
			GetComponent<Animator> ().SetTrigger ("break");
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			hasBeenSteppedOn = true;
		}
	}

}
