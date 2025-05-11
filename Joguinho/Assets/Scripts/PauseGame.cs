using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    private bool isPaused = false;
    private bool pauseSceneActive = false;

   

    void PauseGame()
    {
        if (!pauseSceneActive)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("PauseMenuScene", LoadSceneMode.Additive);
            isPaused = true;
            pauseSceneActive = true;
        }
    }



    public void ResumeGame()
    {
        Time.timeScale = 1f;

        if (SceneManager.GetSceneByName("PauseMenuScene").IsValid() &&
            SceneManager.GetSceneByName("PauseMenuScene").isLoaded)
        {
            SceneManager.UnloadSceneAsync("PauseMenuScene");
        }

        isPaused = false;
        pauseSceneActive = false;
    }



    public void UnpauseFlag()
    {
        isPaused = false;
        pauseSceneActive = false;
    }

}
