using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private Enemy enemigo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemigo.GetDamaged();
    }
}
