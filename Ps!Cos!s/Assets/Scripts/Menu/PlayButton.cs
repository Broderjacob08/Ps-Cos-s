using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnExitClick()
    {
        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }

    public void OnRestartClick()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
