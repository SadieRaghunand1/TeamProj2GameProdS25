using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pMenu;
    public GameObject howPlayImage;

    public bool isPause;
    public bool howPlay;

    // Start is called before the first frame update
    void Start()
    {
        pMenu.SetActive(false);
        isPause = false;
        Time.timeScale = 1f;
        howPlayImage.SetActive(false);
        howPlay = false;
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        howPlayImage.SetActive(false);
        howPlay = false;
    }
    
    public void howToPlay()
    {
        Debug.Log("hi");
        if (howPlay == false)
        {
            howPlayImage.SetActive(true);
            howPlay = true;
            Debug.Log("false");
        }
        else if (howPlay == true)
        {
            howPlayImage.SetActive(false);
            howPlay = false;
            Debug.Log("true");
        }
    }
}
