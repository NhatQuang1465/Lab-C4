using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class IntroCutscene : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button skipButton;
    public string nextScene = "Gameplay";

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoFinished;
        skipButton.onClick.AddListener(SkipCutscene);
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        LoadNext();
    }

    void SkipCutscene()
    {
        LoadNext();
    }

    void LoadNext()
    {
        SceneManager.LoadScene(nextScene);
    }
}