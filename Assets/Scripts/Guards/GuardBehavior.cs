using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardBehavior : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject[] patrolPoints;
    private int patrolIndex = 0;
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerMovement playerMovement;
    private bool patrol = true;

    [SerializeField] private float enemySightDistance;
    [SerializeField] private GameObject[] peripherals;
    private float delayStateTime = 5;


    // Update is called once per frame
    void Update()
    {

       if(patrol)
        {
            Patrol();
        }
       else
        {
            Chase();
        }
    }

    private void FixedUpdate()
    {
        //LookForPlayer();
        RunLookForPlayer();
    }

    /// <summary>
    /// Moves guard between set points in patrol state
    /// </summary>
    void Patrol()
    {
        //Sets destination of patrol point
         agent.SetDestination(patrolPoints[patrolIndex].transform.position);

        //Checks if the guard has reached the point
         if((Mathf.Round(transform.position.x * 100) / 100) == (Mathf.Round(patrolPoints[patrolIndex].transform.position.x * 100) / 100) && transform.position.z == patrolPoints[patrolIndex].transform.position.z) 
         {
            //If it has reached its target patrol point, changes to next one
             Debug.Log("Dest reached");
             if(patrolIndex == patrolPoints.Length - 1)
             {
                Debug.Log("Back to first patrol pt");
                 patrolIndex = 0;
             }
             else
             {
                 patrolIndex++;
             }
                
         }
        
        
    } //END Patrol()


    /// <summary>
    /// 
    /// </summary>
    void Chase()
    {
        Debug.Log("Chase player");
        //Checks if player is in the safe zone, if is not, sets player as destination point
        if(!playerMovement.inSafeZone)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            
            patrol = true;
        }
        
    } //END Chase()


    /// <summary>
    /// Sends out raycast to see if the player has entered the field of view of the guard
    /// </summary>
    void LookForPlayer(GameObject _sightDirection)
    {
        LayerMask _layerMask = LayerMask.GetMask("Player");

        RaycastHit hit;
        if (Physics.Raycast(_sightDirection.transform.position, _sightDirection.transform.TransformDirection(Vector3.forward), out hit, enemySightDistance, _layerMask))

        {
            Debug.DrawRay(_sightDirection.transform.position, _sightDirection.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit player");
            patrol = false;
           
            
        }
        else
        {
            Debug.DrawRay(_sightDirection.transform.position, _sightDirection.transform.TransformDirection(Vector3.forward) * 1000, Color.white);

            if(!patrol)
            {
                StartCoroutine(DelayStateChange());
            }
            
            //Debug.Log("Did not Hit");
        }
    } //END LookForPlayer()

    void RunLookForPlayer()
    {
        for(int i = 0; i < peripherals.Length; i++)
        {
            LookForPlayer(peripherals[i]);
        }
    }

    //When the player is out of view, delays change back to patrol to ensure the illusion of chasing
    IEnumerator DelayStateChange()
    {
        yield return new WaitForSeconds(delayStateTime);
        Debug.Log("Change back to patrol");
        patrol = true;
    } //END DelayStateChange()
}
