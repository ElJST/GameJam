using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFin : MonoBehaviour
{
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.instance;
    }
    public void Continuar()
    {
        manager.Continuar();
    }
}
