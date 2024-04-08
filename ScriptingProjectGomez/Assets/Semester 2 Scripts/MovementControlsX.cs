using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlsX : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;


    private void Update()
    {
        Movement();
    }


    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
