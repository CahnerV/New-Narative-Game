using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string nextSceneName;

    void Start (){
        LoadNextScene();
    }

    
    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
