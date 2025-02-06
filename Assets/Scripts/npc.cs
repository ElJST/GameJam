using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{

    public GameObject cubo;
    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(cubo.transform.position);
    }
}
