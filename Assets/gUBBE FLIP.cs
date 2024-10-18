using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");

        
        Vector2 movement = new Vector2(horizontalInput, 0f);
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);

        
        if (horizontalInput < 0f)
        {
            spriteRenderer.flipX = true; 
        }
        else if (horizontalInput > 0f)
        {
            spriteRenderer.flipX = false;
        }
    }
}