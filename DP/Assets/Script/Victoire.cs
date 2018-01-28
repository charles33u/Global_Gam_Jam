using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoire : MonoBehaviour {
	public int compteur;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "objectif_droit") {
			compteur++;
			if (compteur == 10) {
				col.gameObject.SendMessage ("Joueur 0 a gagne");
			}
		}
		else if (col.gameObject.tag == "objectif_gauche") {
			compteur++;
			if (compteur == 10) {
				col.gameObject.SendMessage ("Joueur 1 a gagne");
	}
}
	}
}
