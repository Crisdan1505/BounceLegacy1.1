using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 5f;

    [Header("Salto")]
    public float jumpForce = 10f;
    public float jumpBufferTime = 0.2f;

    private Rigidbody2D rb;
    private float moveInput;
    private float jumpBufferCounter;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(
            moveInput * speed,
            rb.linearVelocity.y
        );

        if (jumpBufferCounter > 0 && isGrounded)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpForce
            );

            jumpBufferCounter = 0;
            isGrounded = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGrounded = false;
        }
    }
}