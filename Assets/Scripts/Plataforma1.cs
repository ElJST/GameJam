using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma1 : MonoBehaviour
{
    public GameObject Plataforma;
    public Rigidbody2D Rb;
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
        Rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        
    }
}
