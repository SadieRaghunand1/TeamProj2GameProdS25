using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Image cheatInd;
    [SerializeField] private Image speedrunInd;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

        ChangeIndicators();
    }

    void ChangeIndicators()
    {
        if(gameManager.cheatMode == false)
        {
            cheatInd.enabled = false;
        }

        if(gameManager.speedrunMode == false)
        {

        speedrunInd.enabled = false; 
        }
    }
}
