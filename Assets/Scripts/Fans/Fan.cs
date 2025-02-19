using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{

    Rigidbody playerRB;
    [SerializeField] private float fanForce;
    [SerializeField] private float minYBeforeForceAgain;

    public bool needsKeys;

    private void OnTriggerStay(Collider other)
    {
        FanForceUp(other);
    }

    /// <summary>
    /// Generates force upwards of fan
    /// </summary>
    void FanForceUp(Collider _other)
    {
        if(_other.gameObject.layer == 7)
        {
            //Checks if this fan requires keys to operate, if it does and the number of keys isn't correct, exits function
            if(needsKeys && _other.gameObject.GetComponent<Pickup>().CheckGoal() == false)
            {
                return;
            }
            playerRB = _other.gameObject.GetComponent<Rigidbody>();
            playerRB.AddForce(Vector3.up * fanForce, ForceMode.Impulse);

            if(playerRB.position.y < minYBeforeForceAgain)
            {
                playerRB.AddForce(Vector3.up * fanForce, ForceMode.Impulse);
            }
        }
    } //END FanForceUp()
}
