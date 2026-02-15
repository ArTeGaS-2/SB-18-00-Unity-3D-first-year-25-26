using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float jumpFroce = 6f;
    [SerializeField] float groundCheckDistance = 0.6f;

    Rigidbody rb;
    bool isGrounded;

    public GameObject mainCamera;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        isGrounded = Physics.Raycast( // Промінь
            transform.position,  // стартова позиція
            Vector3.down,        // напрямок
            groundCheckDistance);// довжина

        if (Input.GetKeyDown(KeyCode.Space) && 
            isGrounded)
        {
            Vector3 velocity = rb.velocity;
            velocity.y = 0;
            rb.velocity = velocity;
            rb.AddForce(Vector3.up * jumpFroce,
                ForceMode.VelocityChange);
        }
    }
    private void FixedUpdate()
    {
        // керування
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // беремо прискорення об'єкту
        Vector3 velocity = rb.velocity;

        // Прискорення в бік
        velocity.x += horizontal * moveSpeed * Time.fixedDeltaTime;
        velocity.z += vertical * moveSpeed * Time.fixedDeltaTime;

        // повертаємо прискорення об'єкту
        rb.velocity = velocity;
        IfPlayerFall();
    }
    private void IfPlayerFall()
    {
        if (transform.position.y < -30f)
        {
            SceneManager.LoadScene("RedBall");
        }
    }
}
