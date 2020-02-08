using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public float startinghealth = 100f;
    private float health;


    public Animator anim;
    public Image healthBar;
    public float EnemyDamageT = 10f;
    public float chaseRadius;
    public float speed;
    public float stoppingDistance;

    private Transform target;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        health = startinghealth;

    }

    void Update()
    {
        CheckDistance();

        if (health == 0)
        {
            anim.SetBool("dead", true);
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pbullet"))
        {
            health = health - EnemyDamageT;
            healthBar.fillAmount = health / startinghealth;
        }
    }


    void CheckDistance()
    {
        if ((Vector2.Distance(transform.position, target.position) > stoppingDistance) && (Vector2.Distance(target.position, transform.position) <= chaseRadius))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
