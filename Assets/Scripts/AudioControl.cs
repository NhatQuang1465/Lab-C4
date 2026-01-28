using UnityEngine;

public class AudioControl : MonoBehaviour
{
    AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            audioSrc.Play();

        if (Input.GetKeyDown(KeyCode.S))
            audioSrc.Stop();
    }
}