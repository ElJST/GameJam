using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaScript : MonoBehaviour
{
    private GameManager manager;
    private Animator animCasa;
    //private bool Llave = false;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.instance;
        animCasa = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (manager.llave && collision.tag.Equals("Jugador"))
        {
            //animCasa.enabled = true;
            manager.EndGame();
        }
    }
}

