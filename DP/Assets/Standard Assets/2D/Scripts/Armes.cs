using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armes : MonoBehaviour {

    public GameObject myPlayer;
    private Rigidbody2D m_Rigidbody2D;

    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject != myPlayer)
        {
            //lance la fonction toucher
            other.gameObject.GetComponent<PlatformerCharacter2D>().Touch(this);
            Debug.Log("Do something else here");
        }
    }
    public void ReturnAxe()
    {
        m_Rigidbody2D.velocity = new Vector3(m_Rigidbody2D.velocity.x * (-1), m_Rigidbody2D.velocity.y);
    }
}
