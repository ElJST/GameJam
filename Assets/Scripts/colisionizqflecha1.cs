using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionizqflecha1 : MonoBehaviour
{
    public GameObject flecha;
    public Rigidbody2D rb;
    public GameObject collision2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.tag.Equals("mapa")){
            Invoke("moverFlecha", 0.5f);
        }
    }
    void moverFlecha()
    {
        rb.AddForce(transform.right * -200f, ForceMode2D.Impulse);
        collision2.SetActive(false);
    }
}
