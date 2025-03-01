using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLose : MonoBehaviour
{
    GameManager gameManager;

    public void restart()
    {
        gameManager.PlayMenuMusic();
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        gameManager.StopMusicEndGame();
    }
}
