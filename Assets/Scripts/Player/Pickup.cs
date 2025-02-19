using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickup : MonoBehaviour
{
    //Level 2

    //Attach to player
    private int numCollected;
    [SerializeField] private TextMeshProUGUI numUI;

    [SerializeField] int goalCollected;
    private bool reachedGoal;

    private void OnCollisionEnter(Collision collision)
    {
        PickupObject(collision);
    }

    /// <summary>
    /// On collision with pickup, increases the number of pickups collected
    /// </summary>
    void PickupObject(Collision _collision)
    {
        if(_collision.gameObject.layer == 9)
        {
            numCollected++;
            Destroy(_collision.gameObject);
            numUI.text = "Collected: " + numCollected;

            
        }
    } //END PickupObject()

    /// <summary>
    /// Checks if player has the required number of pickups when on fans that require pickups
    /// </summary>
    public bool CheckGoal()
    {
        if(numCollected == goalCollected)
        {
            reachedGoal = true;
            
            Debug.Log("Goal collected");
        }

        return reachedGoal;
    } //END CheckGoal()

    
}
