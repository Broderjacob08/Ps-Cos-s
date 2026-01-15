using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouEscapedScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("EscapeScene");
        }

    }
}
