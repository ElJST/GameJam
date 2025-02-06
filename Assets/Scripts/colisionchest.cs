using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionchest : MonoBehaviour
{
    public GameObject cofre;
    private Animator animator;
    private GameManager manager;
    private Collider2D colision;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        manager = GameManager.instance;
        colision = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Jugador")) {

            animator.enabled = true;
            colision.enabled = false;
        }
    }
}
