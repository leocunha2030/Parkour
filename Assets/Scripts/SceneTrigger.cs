using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para trocar de cena

public class SceneChangeTrigger : MonoBehaviour
{
    public string sceneName; // Nome da cena para carregar

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger possui a tag "Player"
        if (other.CompareTag("Player") && !string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // Carrega a cena especificada
        }
    }
}
