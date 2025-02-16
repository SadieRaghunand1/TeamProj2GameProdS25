using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
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
