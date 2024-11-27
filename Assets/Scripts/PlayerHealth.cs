using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth; // Vida m�xima do jogador
    public int currentHealth; // Vida atual do jogador
    public string sceneName;
    void Start()
    {
        currentHealth = maxHealth; // Define a vida inicial como o valor m�ximo
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduz a vida do jogador
        Debug.Log($"Player levou dano! Vida restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die(); // Chama a fun��o de morte se a vida for menor ou igual a zero
        }
    }

    void Die()
    {
        SceneManager.LoadScene(sceneName);
    }
}
