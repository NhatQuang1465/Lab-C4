using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoControl : MonoBehaviour
{
    private VideoPlayer player;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!player.isPlaying)
                player.Play();
            else
                player.Pause();
        }
    }
}