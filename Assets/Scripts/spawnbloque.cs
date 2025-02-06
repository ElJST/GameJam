using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbloque : MonoBehaviour
{
    public GameObject bloquespawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bloquespawn.SetActive(true);
    }
}
