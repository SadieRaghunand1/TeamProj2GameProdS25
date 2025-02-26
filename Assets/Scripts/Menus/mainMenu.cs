using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    [SerializeField] private GameObject gameManagerPrefab;

    private void Start()
    {
        //Load in game manager if it doesn't exist already, avoid multiple game managers in scene at once
        if (FindAnyObjectByType<GameManager>() == null)
        {
            Instantiate(gameManagerPrefab);
        }
    }


    //functions for each button
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void howToPlay()
    {
        SceneManager.LoadScene(2);
    }
    public void settings()
    {
        SceneManager.LoadScene(3);
    }
    public void quit()
    {
        Application.Quit();
    }
}
