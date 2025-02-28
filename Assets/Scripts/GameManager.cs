using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool cheatMode;
    public bool speedrunMode;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void TurnOnCheatMode()
    {
        cheatMode = !cheatMode;
    }

    public void TurnOnSpeedRun()
    {

    speedrunMode = !speedrunMode; 
    }
}
