using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject menu;
    public GameObject generic;
    public GameObject controls;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        //a décrocher
        Application.LoadLevel("Arene");
    }

    public void quit()
    {
        Debug.Log("the player has quit the game");
        Application.Quit();
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
    //Pour switcher entre Groupe Controls et GroupeMenu
    public void GoControls()
    {
        controls.SetActive(true);
        menu.SetActive(false);
    }
    //Pour switcher entre GroupeMenu et Groupe Controls
    public void GoMenuC()
    {
        controls.SetActive(false);
        menu.SetActive(true);
    }
}
