using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDisgust : MonoBehaviour
{
    // Start is called before the first frame update
    public float startinghealth = 100f;
    private float health;
    public float EnemyDamageT = 10f;
    public float chaseRadius;
    public float speed;
    public float stoppingDistance;

    public GameObject trails;
    public Transform Player;
    private Transform target;
    public Animator anim;
    bool facingRight = true;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        health = startinghealth;

    }

    void Update()
    {
        Vector3 difference = Player.position - transform.position;
        CheckDistance();

        if (health == 0)
        {
            anim.SetBool("dead", true);
            Destroy(gameObject);
        }

        if (difference.x > 0 && facingRight)
        {
            flip();
        }
        if (difference.x < 0 && !facingRight)
        {
            flip();
        }

        Instantiate(trails, transform.position, transform.rotation);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pbullet"))
        {
            health = health - EnemyDamageT;
        }
    }

    void CheckDistance()
    {
        if ((Vector2.Distance(transform.position, target.position) > stoppingDistance) && (Vector2.Distance(target.position, transform.position) <= chaseRadius))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            anim.SetBool("run", true);
        }
        else
            anim.SetBool("run", false);
    }
    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
