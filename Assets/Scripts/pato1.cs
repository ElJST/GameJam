using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sapito : MonoBehaviour
{
    public int rutina = 0;
    public float cronometro;
    public Animator ani;//para animar
    public int direccion;
    public float speed_walk;
    public float speed_run;
    public GameObject target;
    public bool atacando;
    private Rigidbody2D rb;
    private GameManager manager;


    void Start()
    {
        manager = GameManager.instance;
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();//nommbramos animador a ani
        target = GameObject.Find("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        Comportamientos();
    }
    public void Comportamientos()
    {

        ani.SetBool("walk", true);
        rb.velocity = transform.right * speed_walk;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Jugador"))
        {
            manager.Muerte();
        }
    }

}
