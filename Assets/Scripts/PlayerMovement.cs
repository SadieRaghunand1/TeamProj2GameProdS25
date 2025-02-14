using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    Vector3 movement;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float cameraSpeed = 3;

    [SerializeField] private Vector3 jumpForce;

   

    float rotateOffset;

    public GameObject holdPos;

    

    // Update is called once per frame
    void Update()
    {
        MovementUpdate();
        Jump();
    }


    private void FixedUpdate()
    {
        MovementFixed(movement);
        RotatePlayer();
       // Jump();

        
    }

    void MovementUpdate()
    {
        //Movement
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movement = new Vector3(horizontal, 0, vertical);

        //Rotation
        rotateOffset = (rotateOffset + Input.GetAxis("Mouse X") * cameraSpeed) % 360f;
    }

    void MovementFixed(Vector3 moveDirection)
    {
        moveDirection = rb.rotation * moveDirection;

        //rb.velocity = moveDirection * speed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }

    /// <summary>
    /// Player rotates with mouse
    /// </summary>
    void RotatePlayer()
    {
        rb.MoveRotation(Quaternion.Euler(0, rotateOffset, 0));
    } //END RotatePlayer()

    /// <summary>
    /// Player jump
    /// </summary>
    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }
    } //END Jump()

    
    

}
