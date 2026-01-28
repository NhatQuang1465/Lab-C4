using UnityEngine;
using UnityEngine.SceneManagement;

public class EndUIController : MonoBehaviour
{
    public void OnContinue()
    {
        SceneManager.LoadScene("MainMenu");
    }
}