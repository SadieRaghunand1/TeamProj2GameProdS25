using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pMenu;

    public bool isPause;

    // Start is called before the first frame update
    void Start()
    {
        pMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        pMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;

    }

    public void resumeGame()
    {
        pMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

}
