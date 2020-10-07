using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    public GameObject panelGameWin;
    Animator anim;

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("win",true);
            Invoke("activarPanelWin", 3f);
        }
    }

    void activarPanelWin()
    {
        panelGameWin.SetActive(true);
        Time.timeScale = 0f;
    }
}
