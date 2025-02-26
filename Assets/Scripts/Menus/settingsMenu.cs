using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsMenu : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    //functions for each button
    //Cheat Mode
    public void option1() 
    {
        gameManager.TurnOnCheatMode();
    }

    //Speedrun
    public void option2()
    {
        gameManager.TurnOnSpeedRun();
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
