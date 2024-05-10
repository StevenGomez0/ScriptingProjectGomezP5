using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    public Transform other;
    private float distancee;

    // Start is called before the first frame update
    void Start()
    {
        distancee = Vector3.Distance(transform.position, other.position);
        Debug.Log("The distance is " +  distancee);
    }
}
