using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public int keyCollected;
    [SerializeField] private int goalKey;
    [SerializeField] private KeyPickupManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        OpenDoor(collision);
    }


    public void ChangeKeyStatus()
    {
        Debug.Log("KeyCollected");
        keyCollected++;
    }


    void OpenDoor(Collision _collision)
    {
        if(_collision.gameObject.layer == 7 && keyCollected == goalKey)
        {
            manager.ChangeKeyUI(-goalKey);
            Destroy(this.gameObject);
        }
    }

}
