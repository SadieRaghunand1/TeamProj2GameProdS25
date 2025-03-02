using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    private GameManager gameManager;

    public int keyCollected;
    [SerializeField] private int goalKey;
    [SerializeField] private KeyPickupManager manager;

    [SerializeField] private AudioSource audioSource;

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
            this.gameObject.SetActive(false);
        }
    }


    void OpenDoor(Collision _collision)
    {
        if(_collision.gameObject.layer == 7 && keyCollected == goalKey && !gameManager.cheatMode)
        {
            manager.ChangeKeyUI(-goalKey);
            audioSource.Play();
            StartCoroutine(DelayDestroyForSound());
           // Destroy(this.gameObject);
        }

        if(gameManager.cheatMode && _collision.gameObject.layer == 7)
        {
            audioSource.Play();
            StartCoroutine(DelayDestroyForSound());
            //Destroy(this.gameObject);   
        }
    }

    IEnumerator DelayDestroyForSound()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
