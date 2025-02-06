using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platano : MonoBehaviour
{
    public GameObject platano;
    private GameManager manager;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.instance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Jugador"))
        {
            manager.Muerte();
        }
    }
}
