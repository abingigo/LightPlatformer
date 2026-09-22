using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SimplePlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public LayerMask groundMask;
    public Transform groundCheck;
    public float groundCheckRadius = 0.15f;

    Rigidbody2D rb;
    bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);

        float moveX = Input.GetAxisRaw("Horizontal");

        Vector2 v = rb.linearVelocity;
        v.x = moveX * moveSpeed;
        rb.linearVelocity = v;

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            v = rb.linearVelocity;
            v.y = jumpForce;
            rb.linearVelocity = v;
        }
    }
}
