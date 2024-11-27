using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform player;       // Refer�ncia ao Transform do jogador
    public int damage = 1;         // Dano causado pelo trigger
    private Vector3 startPosition; // Posi��o inicial do jogador
    private CharacterController characterController;

    void Start()
    {
        // Salva a posi��o inicial do jogador
        startPosition = player.position;

        // Obt�m o CharacterController do jogador
        characterController = player.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger � o jogador
        if (other.transform == player)
        {
            // Aplica dano ao jogador
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            // Reseta a posi��o do jogador
            if (characterController != null)
            {
                characterController.enabled = false; // Desativa o CharacterController
                player.position = startPosition;    // Altera a posi��o do jogador
                characterController.enabled = true; // Reativa o CharacterController
            }
        }
    }
}
