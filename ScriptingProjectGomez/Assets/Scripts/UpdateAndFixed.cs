using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixed : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
}
