using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour 
{
    [Tooltip("GO FIND SUPPLIES")]
    public string nextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}