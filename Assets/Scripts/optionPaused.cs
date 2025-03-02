using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionPaused : MonoBehaviour
{
    public GameObject easyOn;
    public GameObject easyOff;

    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    void Start()
    {

    }


    void Update()
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
    }
    public void option1()
    {
        gameManager.TurnOnCheatMode();
    }
}
