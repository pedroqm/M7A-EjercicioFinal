using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VidaPersonaje : MonoBehaviour
{
    public GameObject panelGameOver;

    //variables de interfaz del personaje
    int vida;
    public int vidaMax;
    public Slider sliderVida;
    public Image recibirDaño;
    Animator anim;


    private void Awake()
    {
        vida = vidaMax;
        sliderVida.maxValue = vidaMax;
        sliderVida.value = vida;
        anim = recibirDaño.GetComponent<Animator>();
    }
    void AnimacionDaño()
    {
        anim.SetBool("dano", false);
    }
    void RestarVida(int ataque)
    {

        //transform.position = new Vector2(transform.position.x-20, transform.position.y);

        anim.SetBool("dano", true);
        Invoke("AnimacionDaño", 0.1f);
        vida -= ataque;
        sliderVida.value = vida;
        Debug.Log("vida: "+vida);
        if (vida<=0)
        {
            panelGameOver.SetActive(true);
            Time.timeScale = 0f;
            //Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dead")
        {
            panelGameOver.SetActive(true);
            Time.timeScale = 0f;
            vida = 0;
        }
    }
}
