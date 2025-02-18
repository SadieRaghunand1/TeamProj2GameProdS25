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
        LookForPlayer();
    }

    void Patrol()
    {
       
         agent.SetDestination(patrolPoints[patrolIndex].transform.position);

         if((Mathf.Round(transform.position.x * 100) / 100) == (Mathf.Round(patrolPoints[patrolIndex].transform.position.x * 100) / 100) && transform.position.z == patrolPoints[patrolIndex].transform.position.z) 
         {
             Debug.Log("Dest reached");
             if(patrolIndex == patrolPoints.Length - 1)
             {
                 patrolIndex = 0;
             }
             else
             {
                 patrolIndex++;
             }
                
         }
        
        
    }

    void Chase()
    {
        if(!playerMovement.inSafeZone)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            patrol = true;
        }
        
    }


    void LookForPlayer()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, enemySightDistance))

        {
            if(hit.collider.gameObject.layer == 7)
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit player");
                patrol = false;
            }
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);

            if(!patrol)
            {
                StartCoroutine(DelayStateChange());
            }
            
            //Debug.Log("Did not Hit");
        }
    }

    IEnumerator DelayStateChange()
    {
        yield return new WaitForSeconds(delayStateTime);
        Debug.Log("Change back to patrol");
        patrol = true;
    }
}
