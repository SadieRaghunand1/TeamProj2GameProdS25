using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Key : MonoBehaviour, IPickup
{
    [SerializeField] private TextMeshProUGUI numUI;
    [SerializeField] private Door door;

    private void OnCollisionEnter(Collision collision)
    {
        PickupObject(collision);
    }

    /// <summary>
    /// On collision with key, lets the door be opened
    /// </summary>
    public void PickupObject(Collision _collision)
    {
        if (_collision.gameObject.layer == 7)
        {
            
           door.ChangeKeyStatus();
            if(numUI != null)
            numUI.text = "Collected: " + 1;
            Destroy(this.gameObject);

        }
    } //END PickupObject()

}
