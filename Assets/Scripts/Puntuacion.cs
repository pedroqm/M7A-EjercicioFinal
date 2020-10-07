using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{

    public float puntos;
    public TextMeshProUGUI textoPuntuacion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "moneda")
        {
            puntos++;
            textoPuntuacion.text = "Puntuación: " + puntos.ToString("000");
            Debug.Log(puntos);
            Destroy(collision.gameObject);
        }
    }
}
