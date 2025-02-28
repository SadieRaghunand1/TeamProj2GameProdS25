using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool keyCollected;



    private void OnCollisionEnter(Collision collision)
    {
        OpenDoor(collision);
    }


    public void ChangeKeyStatus()
    {
        keyCollected = true;
    }


    void OpenDoor(Collision _collision)
    {
        if(_collision.gameObject.layer == 7 && keyCollected)
        {
            Destroy(this.gameObject);
        }
    }

}
