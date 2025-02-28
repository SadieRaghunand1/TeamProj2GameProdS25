using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    private GameManager gameManager;

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

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        if (gameManager.cheatMode)
        {
            Destroy(this.gameObject);
        }
    }


    void OpenDoor(Collision _collision)
    {
        if(_collision.gameObject.layer == 7 && keyCollected == goalKey && !gameManager.cheatMode)
        {
            manager.ChangeKeyUI(-goalKey);
            Destroy(this.gameObject);
        }
    }

}
