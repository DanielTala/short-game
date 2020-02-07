using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    bool facingRight = true;
    public Animator anim;
    Vector2 movement;

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x != 0 || movement.y != 0)
        {
            anim.SetBool("run", true);
        }

        else
        {
            anim.SetBool("run", false);
        }

        if (difference.x < 0 && facingRight)
        {
            flip();
        }
        if (difference.x>0 && !facingRight)
        {
            flip();
        }

    
    }

    private void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void flip()
    {
            facingRight = !facingRight;
            transform.Rotate(0f, 180f, 0f);
    }
}
