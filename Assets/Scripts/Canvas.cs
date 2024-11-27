using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneToLoad; // Nome da cena a ser carregada, configur�vel no Inspector

    public void PlayGame()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
