using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salidadungeon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject salida;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        salida.SetActive(false);
    }
}
    