using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;  
    public float runSpeed = 10f; 
    public float jumpForce = 5f; 
    public float gravity = -9.8f; 

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    private int jumpCount = 0;      
    private float timer = 0f;      

    void Start()
    {
        controller = GetComponent<CharacterController>();
        jumpCount = 0;
        timer = 0f;
    }

    void Update()
    {
        
        timer += Time.deltaTime;

        
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }

        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        
        float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        controller.Move(move * speed * Time.deltaTime);

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            jumpCount++; 
        }

        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void OnDisable()
    {
        
        GameData.jumpCount = jumpCount;
        GameData.totalTime = timer;
    }
}
