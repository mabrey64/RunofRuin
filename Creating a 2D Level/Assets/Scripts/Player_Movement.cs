using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rb;
    Animator animator;

    public float threshold = -8f;
     
    private BoxCollider2D boxCollider2D;
    private bool canJump;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    { 
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpHeight = 35f;
            rb.velocity = Vector2.up * jumpHeight;
            animator.Play("Jump");
            // Add a timer for how long the player should be in the air and then come down.
        }

        HandleMovement();

    }

    private void HandleMovement()
    {
        float moveSpeed = 10f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);
            animator.Play("Run");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            animator.Play("Run");
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.Play("Idle");
        }
    }

    // Fixed invisible walls by adding composite collider 2D to the tile map and making all of the blocks have uniform collisions.

/*    private void RespawnPlayer()
    {
        var Player = GameObject.FindWithTag("Player");
        if (Player.transform.position.y < threshold)
        {
            GameObject.Find("KillPlayer");
            Player.transform.position = new Vector2(-7.9, -3.11087)
        }
    }

    public void KillPlayer()
    {
        (gameObject);
    }*/

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 1f, platformsLayerMask);
        return raycastHit2D.collider != null;
    }
}

