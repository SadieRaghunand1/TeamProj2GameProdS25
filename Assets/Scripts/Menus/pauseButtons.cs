using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseButtons : MonoBehaviour
{
    public bool option1 = false;
    public bool option2 = false;
    public bool howOption = false;
    public GameObject howPlay;
    public GameObject option1Enabled;
    public GameObject option1Disabled;
    public GameObject option2Enabled;
    public GameObject option2Disabled;

    // Start is called before the first frame update
    public void Start()
    {
       howOption = false;
    }
    public void Update()
    {
        //option 1 code
        if (option1 == false)
        {
            option1Disabled.SetActive(true);
            option1Enabled.SetActive(false);
        }
        else
        {
            option1Disabled.SetActive(false);
            option1Enabled.SetActive(true);
        }
        //option 2 code
        if (option2 == false)
        {
            option2Disabled.SetActive(true);
            option2Enabled.SetActive(false);
        }
        else
        {
            option2Disabled.SetActive(false);
            option2Enabled.SetActive(true);
        }
        //how to play code
        if (howOption == true)
        {
            howPlay.SetActive(true);
        }
        else
        {
            howPlay.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            howOption = false;
        }
    }
    public void options1()
    {
        if (option1 == false)
            option1 = true;
        else option1 = false;
    }

    public void options2()
    {
        if (option2 == false)
            option2 = true;
        else option2 = false;
    }
    public void howToPlay()
    {
        if (howOption == false)
            howOption = true;
        else howOption = false;
    }
}
