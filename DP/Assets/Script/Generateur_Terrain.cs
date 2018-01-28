using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generateur_Terrain : MonoBehaviour {
	public int mapNumber = 1;
	// Use this for initialization
	void Start () {

		for (int i =1; i < mapNumber+1; i++) {
			string pathTerrain1 = "Prefabs/Terrain"+Random.Range (1, 20);
			if (mapNumber == 1) {
				GameObject g1 = Instantiate (Resources.Load (pathTerrain1), Vector2.zero, Quaternion.identity) as GameObject;
			}
			else if (mapNumber % 2 == 0) {
				GameObject g1 = Instantiate (Resources.Load (pathTerrain1), new Vector2 ((i - 1) * 26, 0), Quaternion.identity) as GameObject;
			} else {
				GameObject g1 = Instantiate (Resources.Load (pathTerrain1), new Vector2 ((i-2)*-26, 0), Quaternion.identity) as GameObject;
			}
		}

		GameObject g0 = Instantiate(Resources.Load("Prefabs/Fin_jeu_gauche"), Vector2.zero, Quaternion.identity) as GameObject;
		GameObject g2 = Instantiate(Resources.Load("Prefabs/Fin_jeu_droite"), new Vector2(g0.transform.position.x+mapNumber*26, g0.transform.position.y), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
