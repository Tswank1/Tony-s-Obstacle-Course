using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int moveSpeed = 5;
    private Vector3 moveDir;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float checkRad = .65f;
    [SerializeField] private float fallSpeed = 9;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        rb.velocity = moveDir * moveSpeed;

        if(!IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, -fallSpeed, rb.velocity.z);
        }
        else
        {
            rb.velocity = new Vector3(rb.velocity.x, -.2f, rb.velocity.z);
        }
    }

    private void GetInput()
    {
        moveDir.x = Input.GetAxis("Horizontal");
        moveDir.z = Input.GetAxis("Vertical");
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, checkRad, ground);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRad);
    }
}
