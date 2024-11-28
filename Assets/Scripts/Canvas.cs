using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneToPlay; // Nome da cena padrão a ser carregada
    public string easyScene;   // Nome da cena para o modo Easy
    public string hardScene;   // Nome da cena para o modo Hard

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
