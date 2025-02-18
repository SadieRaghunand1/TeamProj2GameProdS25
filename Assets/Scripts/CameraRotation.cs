using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    float rotateOffset;

    

    [Header("Camera rotation range")]
    [SerializeField] private float camRotateMax;
    [SerializeField] private float camRotateMin;

    [Header("LockRotation")]
    [SerializeField] private float upperBound;
    [SerializeField] private float lowerBound;


    private void Update()
    {
        RotateViewY();
        ActualRotation();
    }

    void RotateViewY()
    {

        //Limit rotation, not working, never being counted in range
        if (transform.localRotation.x > camRotateMin && transform.localRotation.x < camRotateMax) //Doesn't seem to be registering, only registers when min is 0
        {
            //Debug.Log(Input.GetAxis("Mouse Y"));

            if(Input.GetAxis("Mouse Y") < upperBound && Input.GetAxis("Mouse Y") > lowerBound)
            {
                Debug.Log("Inside of mouse pos");
                rotateOffset = 0;
            }

            else
            {
                Debug.Log("Outside of mouse pos");
                rotateOffset = (rotateOffset + Input.GetAxis("Mouse Y") * cameraSpeed) % 360f;
            }
            
            
        }
        else
        {
            Debug.Log("Camera not in range");
            
            if (transform.localRotation.x <= camRotateMin)
            {
                
                rotateOffset = 0.01f;
            }
            else if (transform.localRotation.x >= camRotateMax)
            {
               
                rotateOffset = -0.01f;
            }


        }



    }

    void ActualRotation()
    {
        transform.Rotate(new Vector3(rotateOffset, 0, 0));
    }
}
