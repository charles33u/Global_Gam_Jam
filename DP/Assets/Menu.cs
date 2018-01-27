using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject menu;
    public GameObject generic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Hi()
    {
        Debug.Log("hi");
    }

    //Pour switcher entre GroupeMenu et Groupe Generic
    public void GoMenu()
    {
        generic.SetActive(false);
        menu.SetActive(true);
    }

    //Pour switcher entre Groupe Generic et GroupeMenu
    public void GoGeneric()
    {
        generic.SetActive(true);
        menu.SetActive(false);
    }
}
