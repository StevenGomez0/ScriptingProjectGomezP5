using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysX : MonoBehaviour
{
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");


        for (int i = 1; i < (players.Length+1); i++)
        {
            Debug.Log("Player number " + i + " is named " + players[i-1]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
