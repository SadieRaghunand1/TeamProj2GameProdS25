using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pMenu;
    public GameObject howPlayImage;

    public bool isPause;
    public bool howPlay;
    public bool op;

    public GameObject option21;
    public GameObject option12;
    public GameObject option22;
    public GameObject option11;
    public GameObject optionText;

    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        pMenu.SetActive(false);
        isPause = false;
        Time.timeScale = 1f;
        howPlayImage.SetActive(false);
        howPlay = false;

        op = false; 
        option11.SetActive(false);
        option22.SetActive(false);
        option21.SetActive(false);
        option12.SetActive(false);
        optionText.SetActive(false);

        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame();
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
        op = false;
        optionText.SetActive(false);
        optionPicture();
    }
    public void goMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void howToPlay()
    {

        if (howPlay == false)
        {
            howPlayImage.SetActive(true);
            howPlay = true;
            op = false;
            optionText.SetActive(false);
            optionPicture();
        }
        else if (howPlay == true)
        {
            howPlayImage.SetActive(false);
            howPlay = false;
            op = false;
            optionText.SetActive(false);
            optionPicture();
        }
    }

    public void optionsPaused()
    {
        if (op == false)
        {
            optionText.SetActive(true);
            op = true;
            optionPicture();
            howPlayImage.SetActive(false);
            howPlay = false;
        }
        else if (op == true)
        {
            optionText.SetActive(false);
            op = false;
            optionPicture();
            howPlayImage.SetActive(false);
            howPlay = false;
        }
    }
    public void optionPicture()
    {
        if (gameManager.cheatMode == false && gameManager.speedrunMode == false)
        {
            if (op == false)
            {
                option11.SetActive(false);
            }
            else if (op == true)
            {
                option11.SetActive(true);
            }
        }
        else if (gameManager.cheatMode == true && gameManager.speedrunMode == false)
        {
            if (op == false)
            {
                option21.SetActive(false);
            }
            else if (op == true)
            {
                option21.SetActive(true);
            }
        }
        else if (gameManager.cheatMode == false && gameManager.speedrunMode == true)
        {
            if (op == false)
            {
                option12.SetActive(false);
            }
            else if (op == true)
            {
                option12.SetActive(true);
            }
        }
        else if (gameManager.cheatMode == true && gameManager.speedrunMode == true)
        {
            if (op == false)
            {
                option22.SetActive(false);
            }
            else if (op == true)
            {
                option22.SetActive(true);
            }
        }
    }
}

