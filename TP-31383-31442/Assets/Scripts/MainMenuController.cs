using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // replace with your actual gameplay scene name
    }

    public void QuitGame()
    {
        Application.Quit();
       
    }
}
