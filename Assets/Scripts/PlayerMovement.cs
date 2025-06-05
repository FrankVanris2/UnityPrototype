/**
 * PlayerMovement.cs
 * By: Frank Vanris
 * This script handles player movement and jumping using Unity's new Input System.
 * It requires a Rigidbody component on the player GameObject.
 */

using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MoveSpeed = 10;
    [SerializeField] float JumpForce = 5;
    PlayerControls controls;
    bool isGrounded = true;

    void Awake()
    {
        controls = new PlayerControls();
    }
    void OnEnable()
    {
        controls.Player.Move.Enable();
        controls.Player.Jump.Enable();
        controls.Player.Jump.performed += OnJump;
    }

    void OnDisable()
    {
        controls.Player.Move.Disable();
        controls.Player.Jump.Disable();
        controls.Player.Jump.performed -= OnJump;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = controls.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y) * MoveSpeed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }

    void OnJump(InputAction.CallbackContext context)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {   
        // Checking if colliding to ground.
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = true;
        }
    }
}
