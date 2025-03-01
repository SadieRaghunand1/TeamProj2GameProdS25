using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsMenu : MonoBehaviour
{
    public GameObject speedOff;
    public GameObject speedOn;
    public GameObject easyOn;
    public GameObject easyOff;

    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    public void Start()
    {
        easyOn.SetActive(false);
        speedOn.SetActive(false);

    }
    public void Update()
    {
        if (gameManager.cheatMode == false)
        {
            easyOn.SetActive(false);
            easyOff.SetActive(true);
        }
        else
        {
            easyOn.SetActive(true);
            easyOff.SetActive(false);
        }
        if (gameManager.speedrunMode == false)
        {
            speedOn.SetActive(false);
            speedOff.SetActive(true);
        }
        else
        {
            speedOn.SetActive(true);
            speedOff.SetActive(false);
        }
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
