using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;  // Velocidade normal
    public float runSpeed = 10f; // Velocidade ao correr
    public float jumpForce = 5f; // Força do pulo
    public float gravity = -9.8f; // Gravidade personalizada

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    private int jumpCount = 0;      // Contador de pulos
    private float timer = 0f;      // Contador de tempo

    void Start()
    {
        controller = GetComponent<CharacterController>();
        jumpCount = 0;
        timer = 0f;
    }

    void Update()
    {
        // Atualiza o tempo decorrido
        timer += Time.deltaTime;

        // Verifica se o jogador está no chão
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Mantém o personagem preso ao chão
        }

        // Movimentação no eixo X e Z
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        // Alterna entre andar e correr
        float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        controller.Move(move * speed * Time.deltaTime);

        // Pular
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            jumpCount++; // Incrementa o contador de pulos
        }

        // Aplica gravidade
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void OnDisable()
    {
        // Salva os dados no GameData antes de sair da cena
        GameData.jumpCount = jumpCount;
        GameData.totalTime = timer;
    }
}
