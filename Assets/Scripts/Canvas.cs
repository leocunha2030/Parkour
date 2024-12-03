using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneToPlay; 
    public string easyScene;   
    public string hardScene;   

    public void PlayDefault()
    {
        if (!string.IsNullOrEmpty(sceneToPlay))
        {
            SceneManager.LoadScene(sceneToPlay);
        }
    }

    public void PlayEasy()
    {
        if (!string.IsNullOrEmpty(easyScene))
        {
            SceneManager.LoadScene(easyScene);
        }
    }

    public void PlayHard()
    {
        if (!string.IsNullOrEmpty(hardScene))
        {
            SceneManager.LoadScene(hardScene);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
