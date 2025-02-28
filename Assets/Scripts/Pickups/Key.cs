using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Key : MonoBehaviour, IPickup
{
    [SerializeField] private TextMeshProUGUI numUI;
    [SerializeField] private Door door;
    [SerializeField] private KeyPickupManager manager;
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
            Debug.Log("hit player");
           door.ChangeKeyStatus();
            //manager.ChangeKeyUI();
            Destroy(this.gameObject);

        }
    } //END PickupObject()

}
