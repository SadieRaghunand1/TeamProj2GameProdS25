using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseMenu : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        gameManager.StopMusicEndGame();
    }

    public void restart()
    {
        gameManager.PlayMenuMusic();
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}
