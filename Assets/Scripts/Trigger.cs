using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform player;       
    public int damage = 1;        
    private Vector3 startPosition;
    private CharacterController characterController;

    void Start()
    {
        startPosition = player.position;

        characterController = player.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            if (characterController != null)
            {
                characterController.enabled = false; 
                player.position = startPosition;   
                characterController.enabled = true; 
            }
        }
    }
}
