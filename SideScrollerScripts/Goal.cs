using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //public goalAudioSource audioSource;
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete");
            Time.timeScale = 0;
            //AudioSource.PlayClipAtPoint(UndertaleSFX2, transform.position);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
