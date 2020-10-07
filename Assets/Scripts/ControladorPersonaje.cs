using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{

    public float velocidad;
    public float potenciaSalto;
    float movimientoX;
    Rigidbody2D rbPlayer;
    SpriteRenderer srPlayer;
    public bool enSuelo = true;
    public LayerMask suelo;
    Transform pies;

    Animator anim;

    void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        srPlayer = GetComponent<SpriteRenderer>();
        pies = GameObject.Find("Pies").transform;
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(pies.position, 0.08f, suelo);

        if (Input.GetButtonDown("Jump") && enSuelo)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, potenciaSalto);
            //rbPlayer.AddForce(Vector2.up * potenciaSalto, ForceMode2D.Impulse);
            enSuelo = false;
        }
    }

    void Update()
    {
        
        movimientoX = Input.GetAxis("Horizontal");

        //rbPlayer.velocity = new Vector2(movimientoX * velocidad, rbPlayer.velocity.y);
        this.gameObject.transform.Translate(Vector2.right * velocidad * movimientoX * Time.deltaTime);


        Animaciones();
        Flip();

    }

    void Flip()
    {
        if (movimientoX > 0)
        {
            srPlayer.flipX = false;
        }
        else if (movimientoX < 0)
        {
            srPlayer.flipX = true;
        }
    }

    void Animaciones()
    {
        anim.SetFloat("MovX", Mathf.Abs(movimientoX));
        anim.SetFloat("MovY", GetComponent<Rigidbody2D>().velocity.y);
        anim.SetBool("enSuelo", enSuelo);
    }
}
