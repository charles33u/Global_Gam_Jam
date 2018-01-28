using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject p1 = GameObject.FindWithTag ("Player");
		Vector3 pos_camera = transform.position;
		if (p1 != null) {
			Debug.Log (p1.transform.position);
			if (p1.transform.position.x > pos_camera.x + 10) {
				Debug.Log (p1.transform.position);
				Debug.Log ("test1"+pos_camera);
				pos_camera.x  += 10;
			} else if (p1.transform.position.x < pos_camera.x -10) {
				Debug.Log ("test2"+pos_camera);
				pos_camera.x -= 10;
			}
			if(transform.position.x != pos_camera.x)
				transform.position = pos_camera;
		}
	}
}
