using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float showTime;
    private float timerTime;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RunTimer();
    }

    void InitValues()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        if(gameManager.speedrunMode)
        {
            timerTime = 75;
        }
        else
        {
            timerTime = 90;
        }
    }


    void RunTimer()
    {
        timerTime -= Time.deltaTime;
        showTime = (Mathf.Round(timerTime) * 100) / 100;
        timerText.text = showTime.ToString();

        if(timerTime <= 0)
        {
            SceneManager.LoadScene(5);
        }
    }
}
