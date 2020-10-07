using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float lenght, starPos;
    public GameObject cam;

    public float parallax;
    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

   
    void Update()
    {
        float movimiento = (cam.transform.position.x * (1 - parallax));
        float distancia = (cam.transform.position.x * parallax);

        transform.position = new Vector2(starPos + distancia, transform.position.y);

        if (movimiento > starPos + lenght)
        {
            starPos += lenght;
        }
        else if (movimiento < starPos - lenght)
        {
            starPos -= lenght;
        }
    }
}
