using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool hasKey1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        transform.Translate(movement.normalized * 0.1f, Space.World);
        transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
    }


    public void gotKey()
    {
        Debug.Log("This works");
        hasKey1 = true;
    }
}
