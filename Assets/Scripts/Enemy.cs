using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int lifeTotal = 1;
    public int EnemySpeed = 20;
    private Rigidbody2D rb;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTotal < 0)
        {
            manager.Muerte();
        }
        rb.velocity = transform.right * EnemySpeed;
    }
    public void GetDamaged()
    {
        lifeTotal--;

    }
}
