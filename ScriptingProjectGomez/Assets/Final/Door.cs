using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Movement controller;
    void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            if(controller.hasKey1 == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
