using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquesMiniFoso : MonoBehaviour
{
    public GameObject BloquesFoso;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BloquesFoso.SetActive(true);
    }

}
