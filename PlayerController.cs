using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{  
    public float moveSpeed = 10f;
    public float jumpForce = 5f;
    public float gravity = -20f;
    public int maxJumps =2;

    public Transform groundCheck;
    public LayerMask groundLayer;
    
    private Rigidbody rb;
    private Vector3 velocity;
   
    private CharacterController controller;
    private bool isGrounded;
    private int jumpsRemaining;
    private AudioSource audioSource;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpsRemaining = maxJumps;
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        // Check if the player is grounded
         bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);
            
        //isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);
        



        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
       
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
        Vector3 move = transform.TransformDirection(moveDirection) * moveSpeed;
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, 0f);
       


        // Jumping
        if (isGrounded)
        {
            jumpsRemaining = maxJumps;  // Reset jumps when grounded.
        }

        if (jumpsRemaining > 0 && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, 0f);  // Zero out vertical velocity.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpsRemaining--;

            audioSource.Play();
        }
   
    }


}

