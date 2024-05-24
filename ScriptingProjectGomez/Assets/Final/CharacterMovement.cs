using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 movementDirection;
    private Vector3 lookDirection;
    void Start()
    {
       
    }

    private void FixedUpdate()
    {
        Inputs();
        MovePlayer();
    }

    void Inputs()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        movementDirection = new Vector3(horizontalInput * speed * Time.deltaTime, transform.position.y, verticalInput * speed * Time.deltaTime);
        //transform.LookAt(movementDirection);
        transform.position += movementDirection;
    }
}
