using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuSceneManager : MonoBehaviour
{
    public void ResumeGame()
    {
        Debug.Log("Attempting to resume...");

        Time.timeScale = 1f;

        // Loop over all loaded scenes to safely find PauseMenuScene
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name == "PauseMenuScene")
            {
                SceneManager.UnloadSceneAsync("PauseMenuScene");
                break;
            }
        }

        // Reset flags
        var pauseCtrl = Object.FindFirstObjectByType<PauseController>();
        if (pauseCtrl != null)
            pauseCtrl.UnpauseFlag();
    }




    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
