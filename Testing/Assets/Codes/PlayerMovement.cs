using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float startinghealth = 100f;
    public Rigidbody2D rb;
    public Image healthBar;
    bool facingRight = true;
    public Animator anim;
    Vector2 movement;
    private float health;
    public float EnemyDamageB = 10f;
    public float EnemyDamageT = 10f;
    public float EnemyPoison = 1f;
    public float secs;
    public float slowTime;
    public float poisonTime;
    public bool startTime = false;
    public bool poison = false;
    private void Start()
    {
        health = startinghealth;
    }
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

        if (startTime == true)
        {
            secs++;
            moveSpeed = 1f;
            if (secs >= slowTime)
            {
                startTime = false;
                moveSpeed = 3f;
                secs = 0f;
            }

        if (poison == true)
            {
                secs++;
                health--;
                healthBar.fillAmount = health / startinghealth;
                if (secs >= poisonTime)
                {
                    poison = false;
                    secs = 0f;
                }
            }
        }

    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BulletE"))
        {
            health = health - EnemyDamageT;
            healthBar.fillAmount = health / startinghealth;
        }
        if (collision.gameObject.CompareTag("BulletSad"))
        {
            health = health - EnemyDamageB;
            timer();
            healthBar.fillAmount = health / startinghealth;
        }
        if (collision.gameObject.CompareTag("BulletJoy"))
        {
            health = health - EnemyDamageB;
            healthBar.fillAmount = health / startinghealth;
        }
        if (collision.gameObject.CompareTag("Trail"))
        {
            poison = true;
        }
    }

    private void timer()
    {
        startTime = true;
        
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
