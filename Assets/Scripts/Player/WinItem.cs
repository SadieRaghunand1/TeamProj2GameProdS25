using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        CollectWinItem(collision);
    }

    void CollectWinItem(Collision _collision)
    {
        if(_collision.gameObject.layer == 7)
        {
            //Win!
            Debug.Log("Level won!");
            Destroy(this.gameObject);
        } 
    }
}
