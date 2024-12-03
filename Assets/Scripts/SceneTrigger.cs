using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChangeTrigger : MonoBehaviour
{
    public string sceneName; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); 
        }
    }
}
