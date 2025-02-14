using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{

    Rigidbody playerRB;
    [SerializeField] private float fanForce;
    [SerializeField] private float minYBeforeForceAgain;

   /* private void OnTriggerEnter(Collider other)
    {
        FanForceUp(other);
    }*/

    private void OnTriggerStay(Collider other)
    {
        FanForceUp(other);
    }


    void FanForceUp(Collider _other)
    {
        if(_other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            playerRB = _other.gameObject.GetComponent<Rigidbody>();
            playerRB.AddForce(Vector3.up * fanForce, ForceMode.Impulse);

            if(playerRB.position.y < minYBeforeForceAgain)
            {
                playerRB.AddForce(Vector3.up * fanForce, ForceMode.Impulse);
            }
        }
    }
}
