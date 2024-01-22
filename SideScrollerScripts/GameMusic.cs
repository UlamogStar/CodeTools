using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Set the audio clip to loop
        audioSource.loop = true;

        // Assign the audio clip from the inspector
        audioSource.clip = audioClip;

        // Play the audio clip
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if a specific input or event occurs to stop the music
        if (Input.GetKeyDown(KeyCode.End))
        {
            // Stop the audio clip
            audioSource.Stop();
        }
    }
}
