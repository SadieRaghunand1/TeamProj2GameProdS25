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


    private void Start()
    {
        numUIKey.text = 0.ToString();
        numUIPU.text = 0.ToString();
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
}
