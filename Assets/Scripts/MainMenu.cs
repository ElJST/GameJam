using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditos;
    private GameManager manager;
    private void Start()
    {
        manager = GameManager.instance;
    }
    public void Play()
    {
        manager.Inicio();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Creditos()
    {
        mainMenu.SetActive(false);
        creditos.SetActive(true);
    }
    public void Volver()
    {
        creditos.SetActive(false);
        mainMenu.SetActive(true);
    }
}
