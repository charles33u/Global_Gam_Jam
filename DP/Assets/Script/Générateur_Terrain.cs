using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Générateur_Terrain : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("hi");
		string pathTerrain1 = "Prefabs/Terrain"+Random.Range (1, 20);
		string pathTerrain2 = "Prefabs/Terrain"+Random.Range (1, 20);
		string pathTerrain3 = "Prefabs/Terrain"+Random.Range (1, 20);
		Debug.Log (pathTerrain1 + " " + pathTerrain2 + " " + pathTerrain3);

		GameObject g1 = Instantiate(Resources.Load(pathTerrain1), Vector2.zero, Quaternion.identity) as GameObject;
		GameObject g2 = Instantiate(Resources.Load(pathTerrain2), new Vector2(g1.transform.position.x-26, g1.transform.position.y), Quaternion.identity) as GameObject;
		GameObject g3 = Instantiate(Resources.Load(pathTerrain3), new Vector2(g1.transform.position.x+26, g1.transform.position.y), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
