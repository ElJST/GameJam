using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerGUI : MonoBehaviour
{
    private GameManager manager;
    public TMP_Text muertesTexto;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        muertesTexto.text = "Muertes: "+manager.muertes;
    }
}
