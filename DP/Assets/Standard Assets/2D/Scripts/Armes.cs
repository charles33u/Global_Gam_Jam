using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armes : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //lance la fonction toucher
            other.gameObject.GetComponent<PlatformerCharacter2D>().Touch();
            Debug.Log("Do something else here");
        }
    }
}
