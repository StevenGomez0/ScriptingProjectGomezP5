using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math : MonoBehaviour
{
    public int integer1;
    public int integer2;
    // Start is called before the first frame update
    void Start()
    {
        integer1 += integer2;
        Debug.Log("The sum of both integers is " + integer1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
