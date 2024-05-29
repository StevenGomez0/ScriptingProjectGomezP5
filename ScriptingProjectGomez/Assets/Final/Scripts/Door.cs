using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Movement controller;
    private bool doorActive = false;
    void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            if (controller.hasKey1 == true)
            {
                doorActive = true;
                Debug.Log("Door Activated");
            }
        }
    }

    private void FixedUpdate()
    {
        if (doorActive == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }

        }
    }
}
