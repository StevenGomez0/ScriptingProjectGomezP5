using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject camPos;
    private Vector3 playerPos;
    [SerializeField] private int offsetUp = 10;
    [SerializeField] private int offsetZ = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(transform.position.x, transform.position.y+offsetUp, transform.position.z+offsetZ);
        camPos.transform.position = playerPos;
    }
}
