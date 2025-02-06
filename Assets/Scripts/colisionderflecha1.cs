using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionderflecha1 : MonoBehaviour
{
    public GameObject flecha;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.tag.Equals("mapa"))
        {
            Invoke("moverFlecha", 0.5f);
        }
    }
    void moverFlecha()
    {
        flecha.transform.Rotate(0, 180f, 0);
        rb.AddForce(transform.right * 200f, ForceMode2D.Impulse);
        
    }
}
