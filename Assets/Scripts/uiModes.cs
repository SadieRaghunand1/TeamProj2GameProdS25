using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class uiModes : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject easyMode;
    public GameObject speedrun;
    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        if (gameManager.cheatMode)
        {
            easyMode.SetActive(true);
        }
        else
        {
            easyMode.SetActive(false);
        }
        if (gameManager.speedrunMode)
        {
            speedrun.SetActive(true);
        }
        else
        {
            speedrun.SetActive(false);
        }
    }

}
