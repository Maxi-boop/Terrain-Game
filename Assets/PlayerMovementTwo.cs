using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTwo : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public string NextLevel;
    public string CurrentLevel;
    public int num = 0;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Finish")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextLevel); 
        }
        if(other.tag == "Death")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(CurrentLevel);
        }
    }
}
