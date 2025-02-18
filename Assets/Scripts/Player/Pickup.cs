using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickup : MonoBehaviour
{
    //Level 2

    //Attach to player
    public int numCollected;
    [SerializeField] private TextMeshProUGUI numUI;

    [SerializeField] private int goalCollected;

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

            CheckGoal();
        }
    }

    void CheckGoal()
    {
        if(numCollected == goalCollected)
        {
            //Add end game functionality
            Debug.Log("Goal collected");
        }
    }
}
