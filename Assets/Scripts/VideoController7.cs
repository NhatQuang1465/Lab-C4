using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer player;
    public GameObject endPanel;

    void Start()
    {
        // UI tắt sẵn
        if (endPanel != null)
            endPanel.SetActive(false);

        // đăng ký sự kiện
        player.prepareCompleted += OnVideoPrepared;
        player.loopPointReached += OnVideoEnded;

        // chuẩn bị video
        player.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared, starting...");
        vp.Play();
    }

    void Update()
    {
        // phím E → kết thúc video
        if (Input.GetKeyDown(KeyCode.E))
        {
            SkipToEnd();
        }
    }

    void SkipToEnd()
    {
        Debug.Log("Skipping to end...");
        player.time = player.length - 0.1f; // để đảm bảo trigger loopPointReached
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        Debug.Log("Video ended!");

        if (endPanel != null)
            endPanel.SetActive(true);

        // nếu muốn chuyển scene luôn thì bật dòng này:
        // SceneManager.LoadScene("MenuScene");
    }

  
}