using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth; 
    public int currentHealth; 
    public string sceneName;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        Debug.Log($"Player levou dano! Vida restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        SceneManager.LoadScene(sceneName);
    }
}
