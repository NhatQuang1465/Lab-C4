using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        // MUTE TOGGLE
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Global Mute" : "Global Unmute");
        }

        // PAUSE TOGGLE
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                AudioListener.pause = true;
                Debug.Log("Global Pause");
            }
            else
            {
                AudioListener.pause = false;
                Debug.Log("Global Resume");
            }
        }
    }
}