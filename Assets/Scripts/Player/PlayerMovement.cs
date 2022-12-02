using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    public Rigidbody rb;

    [Header("Movement")]
    public float moveSpeed;
    public float jumpForce;
    public KeyCode jumpKey = KeyCode.LeftShift;

    private bool grounded;

    private void Start()
    {
        grounded = false;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        rb.transform.position += move * moveSpeed * Time.deltaTime;

        if(grounded && Input.GetKey(jumpKey))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Vector3 jumpForceToAdd = rb.transform.up * jumpForce * Time.deltaTime;

        rb.AddForce(jumpForceToAdd, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            grounded = true;
        }

        if (other.gameObject.CompareTag("Fence"))
        {
            moveSpeed = -moveSpeed;
            rb.freezeRotation = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = false;
        }

        if (other.gameObject.CompareTag("Fence"))
        {
            moveSpeed = -moveSpeed;
            rb.freezeRotation = false;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; 
        }
    }
}
