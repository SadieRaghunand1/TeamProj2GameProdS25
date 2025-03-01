using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool cheatMode;
    public bool speedrunMode;

    public AudioSource bgMusic;
    public AudioClip menuMusic;
    public AudioClip gameMusic;

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

    public void PlayMenuMusic()
    {
        bgMusic.clip = menuMusic;
        bgMusic.Play();
    }

    public void PlayGameMusic()
    {
        bgMusic.clip = gameMusic;
        bgMusic.Play();
    }

    public void StopMusicEndGame()
    {
        bgMusic.Stop();
    }

}
