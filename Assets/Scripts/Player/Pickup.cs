using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickup : MonoBehaviour
{
    //Attach to player
    public int numCollected;
    [SerializeField] private TextMeshProUGUI numUI;

    private void OnCollisionEnter(Collision collision)
    {
        PickupObject(collision);
    }

    void PickupObject(Collision _collision)
    {
        if(_collision.gameObject.layer == 9)
        {
            numCollected++;
            Destroy(_collision.gameObject);
            numUI.text = "Collected: " + numCollected;
        }
    }
}
