using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickup : MonoBehaviour, IPickup
{
    //Level 2

    //Attach to player
    public int numCollected;
    [SerializeField] private TextMeshProUGUI numUI;
    [SerializeField] private KeyPickupManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        PickupObject(collision);
    }

    /// <summary>
    /// On collision with pickup, increases the number of pickups collected
    /// </summary>
    public void PickupObject(Collision _collision)
    {
        if(_collision.gameObject.layer == 9)
        {
            numCollected++;
            Destroy(_collision.gameObject);
            //numUI.text = "Collected: " + numCollected;
            //manager.ChangePickupUI();
            
        }
    } //END PickupObject()

   
}
