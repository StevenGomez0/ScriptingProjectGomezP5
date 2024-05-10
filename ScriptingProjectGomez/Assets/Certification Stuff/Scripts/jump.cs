using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody rb;
    public float gravity;
    public float jumpHeight;
    private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravity;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        
    }
}
