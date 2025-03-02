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

    [SerializeField] private AudioSource audioSource;
    private GameObject pickUp;

    //[SerializeField] private GameObject[] keyCardObjs;

   
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
            pickUp = _collision.gameObject;
            audioSource = _collision.gameObject.GetComponent<AudioSource>();
            audioSource.Play();
            numCollected++;
            manager.ChangePickupUI();
            StartCoroutine(DelayDestroyForSound(_collision));

            
        }
    } //END PickupObject()


    IEnumerator DelayDestroyForSound(Collision _collision)
    {

        if (_collision.gameObject.layer == 9)
        {
            _collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
            _collision.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(2f);
            Debug.Log("Delay + " + pickUp.name);
            Destroy(pickUp);
        }
        
    }

}
