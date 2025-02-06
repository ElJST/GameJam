using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public int muertes { get; set; }= 0;
    public bool llave { get; set; } = false;
    
    #region Singleton

    //Use a property so other code can't assign instance.
    static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            if (!_instance)
                _instance = new GameObject("GameManager", typeof(GameManager)).GetComponent<GameManager>();
            return _instance;
        }
    }

    void EnsureSingleton()
    {
        if (!_instance)
            _instance = this;

        var gameManagerInstances = GameObject.FindObjectsOfType<GameManager>();

        if (gameManagerInstances.Length != 1)
        {
            Debug.LogError("Only one instance of the GameManager manager should ever exist. Removing extraneous.");

            foreach (var otherInstance in gameManagerInstances)
            {
                if (otherInstance != instance)
                {

                    if (otherInstance.gameObject == instance.gameObject)
                        Destroy(otherInstance);
                    else
                        Destroy(otherInstance.gameObject);
                }
            }
        }

    }
    #endregion Singleton

    private void Awake()
    {
        EnsureSingleton();
        muertes = PlayerPrefs.GetInt("muertes", 0);
        PlayerPrefs.SetInt("muertes", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openMenu();
        }
    }
    public void openMainMenu()
    {
        SceneManager.LoadScene(1);
    }
    void openMenu()
    {   
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Inicio()
    {
        SceneManager.LoadScene(2);
    }
    public void Muerte()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        muertes++;
        PlayerPrefs.SetInt("muertes", muertes);
        PlayerPrefs.Save();
    }
    public void TakeKey()
    {
        llave = true;
    }
    public void EndGame()
    {
        SceneManager.LoadScene(3);
    }
    public void Continuar()
    {
        PlayerPrefs.SetInt("muertes", 0);
        SceneManager.LoadScene(1);
    }
}
