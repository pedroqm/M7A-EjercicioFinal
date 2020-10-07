using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject personaje = collision.collider.gameObject;
            personaje.SendMessage("RestarVida",5);
            Debug.Log("Restar vida");
        }
    }
}
