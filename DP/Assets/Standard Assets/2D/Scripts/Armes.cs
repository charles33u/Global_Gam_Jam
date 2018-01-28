using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armes : MonoBehaviour {

    public GameObject myPlayer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject != myPlayer)
        {
            //lance la fonction toucher
            other.gameObject.GetComponent<PlatformerCharacter2D>().Touch(this.gameObject);
            Debug.Log("Do something else here");
        }
    }
}
