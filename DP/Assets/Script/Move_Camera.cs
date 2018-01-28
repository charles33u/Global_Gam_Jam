using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour {

	public float offsetY = 5f;
	public float cameraDepthMin = -10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!PlayersAreReady ())
			return;
		Vector3 centerPlayers = (PlatformerCharacter2D.players [0].transform.position + PlatformerCharacter2D.players [1].transform.position) / 2;
		float cameraDepth = Mathf.Min(cameraDepthMin, PlayerDistance() * -1) ;
		transform.position = new Vector3 (centerPlayers.x, centerPlayers.y + offsetY, cameraDepth);
	}

	private float PlayerDistance(){
		return (PlatformerCharacter2D.players [0].transform.position - PlatformerCharacter2D.players [1].transform.position).magnitude;
	}

	private bool PlayersAreReady(){
		return PlatformerCharacter2D.players [0] != null && PlatformerCharacter2D.players [1] != null; 
	}
}

/*

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
*/
