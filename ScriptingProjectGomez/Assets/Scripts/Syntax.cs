using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //nothing here
    }
    void Update()
    {
        //this line tells me the x position of my object

        /* cool
         * theres multiple lines
         * */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5.0f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
