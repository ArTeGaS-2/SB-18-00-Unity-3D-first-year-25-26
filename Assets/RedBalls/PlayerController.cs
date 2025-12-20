using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float jumpFroce = 6f;
    [SerializeField] float groundCheckDistance = 0.6f;

    Rigidbody rb;
    bool isGrounded;

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
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 velocity = rb.velocity;
        velocity.x = horizontal * moveSpeed;
        rb.velocity = velocity;
    }
}
