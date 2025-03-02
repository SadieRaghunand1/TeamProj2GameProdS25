using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class KeyPickupManager : MonoBehaviour
{
    private int keyCount;
    private int pickupCount;


    [SerializeField] private TextMeshProUGUI numUIKey;
    [SerializeField] private TextMeshProUGUI numUIPU;

    [SerializeField] private GameObject[] allKeys;
    [SerializeField] private GameObject[] allKeycards;
    [SerializeField] private Fan[] pickupFans;
    [SerializeField] private Door[] keyDoors;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        numUIKey.text = 0.ToString();
        numUIPU.text = 0.ToString();

        if(gameManager.cheatMode)
        {
            CheatModeEnabledKeysAndPU();
        }
    }

    public void ChangeKeyUI(int _change)
    {
        keyCount+= _change;
        numUIKey.text = keyCount.ToString();
    }

    public void ChangePickupUI()
    {
        pickupCount++;
        numUIPU.text = pickupCount.ToString();
    }

    /// <summary>
    /// Runs whenever game starts or is resumed, sets keys and pickups inactive is cheatmode is enabled, sets door inactive
    /// </summary>
    public void CheatModeEnabledKeysAndPU()
    {
        //Keys
        for(int i = 0; i < allKeys.Length; i++)
        {
            if (allKeys[i] != null)
            {
                allKeys[i].SetActive(false);
            }
        }

        //Pickups
        for(int i = 0; i < allKeycards.Length; i++)
        {
            if (allKeycards[i] != null)
            {
                allKeycards[i].SetActive(false);
            }
        }

        //Doors
        for (int i = 0; i < keyDoors.Length; i++)
        {
            if (keyDoors[i] != null)
            {
                keyDoors[i].gameObject.SetActive(false);
            }
        }

    }

    /// <summary>
    /// Runs whenever game is resumed, sets keys and pickups active, doors active
    /// </summary>
    public void DisableCheatMode()
    {
        //Keys
        for (int i = 0; i < allKeys.Length; i++)
        {
            if (allKeys[i] != null)
            {
                allKeys[i].SetActive(true);
            }
        }

        //Pickups
        for (int i = 0; i < allKeycards.Length; i++)
        {
            if (allKeycards[i] != null)
            {
                allKeycards[i].SetActive(true);
            }
        }

        //Doors
        for(int i = 0; i < keyDoors.Length; i++)
        {
            if (keyDoors[i] != null)
            {
                keyDoors[i].gameObject.SetActive(true);
            }
        }

        //Fans
       /* for(int i = 0; i < pickupFans.Length; i++)
        {

        }*/
    }

}
