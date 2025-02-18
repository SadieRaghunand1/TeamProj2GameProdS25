using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float seconds;

    private void Start()
    {
        StartCoroutine(TimeMovement());
    }


    private void Update()
    {
        Move();
    }


    private void Move()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    IEnumerator TimeMovement()
    {
        yield return new WaitForSeconds(seconds);
        speed = -(speed);

        StartCoroutine(TimeMovement());
    }
}
