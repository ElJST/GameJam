using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valla2 : MonoBehaviour
{
    public GameObject valla22;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        valla22.SetActive(false);
    }
}
