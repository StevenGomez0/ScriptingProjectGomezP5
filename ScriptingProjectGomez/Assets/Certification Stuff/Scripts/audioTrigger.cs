using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collosion)
    {
        if (collosion.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(audioClip);
            Debug.Log("this is working correctly");
        }
    }
}
