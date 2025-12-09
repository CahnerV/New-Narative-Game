using UnityEngine;
using UnityEngine.SceneManagement;

public class RVSceneLoader : MonoBehaviour 
{
    [Tooltip("GO FIND SUPPLIES")]
    public bool playerInRange;
    public string nextSceneName;

    public void Start (){
        playerInRange = false;
    }

    public void Update (){
       
        if (playerInRange && Input.GetKeyDown("e"))
            {
                LoadNextScene();
            }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Player"))
            {
                playerInRange = true;
            }

    }

        private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.CompareTag("Player"))
            {
                playerInRange = false;
            }

    }




    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}