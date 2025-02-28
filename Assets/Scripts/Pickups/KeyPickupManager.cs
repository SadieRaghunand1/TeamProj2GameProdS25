using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyPickupManager : MonoBehaviour
{
    private int keyCount;
    private int pickupCount;


    [SerializeField] private TextMeshProUGUI numUIKey;
    [SerializeField] private TextMeshProUGUI numUIPU;


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
}
