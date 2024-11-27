using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform player;       // Referência ao Transform do jogador
    public int damage = 1;         // Dano causado pelo trigger
    private Vector3 startPosition; // Posição inicial do jogador
    private CharacterController characterController;

    void Start()
    {
        // Salva a posição inicial do jogador
        startPosition = player.position;

        // Obtém o CharacterController do jogador
        characterController = player.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger é o jogador
        if (other.transform == player)
        {
            // Aplica dano ao jogador
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            // Reseta a posição do jogador
            if (characterController != null)
            {
                characterController.enabled = false; // Desativa o CharacterController
                player.position = startPosition;    // Altera a posição do jogador
                characterController.enabled = true; // Reativa o CharacterController
            }
        }
    }
}
