using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveScript : MonoBehaviour
{
    private GameManager manager;

    private void Start()
    {
        manager = GameManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.TakeKey();
        gameObject.SetActive(false);
    }
}
