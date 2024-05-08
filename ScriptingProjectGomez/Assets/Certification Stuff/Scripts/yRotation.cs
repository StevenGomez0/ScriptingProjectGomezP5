using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yRotation : MonoBehaviour
{
    public float rot;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, y, 0);
        y += rot;
    }
}
