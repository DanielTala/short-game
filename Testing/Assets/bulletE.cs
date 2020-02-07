using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletE : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    PlayerMovement target;
    
    Vector2 moveDirection;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }


    }



}
