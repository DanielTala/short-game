using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Vector3 target;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = target * speed;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }


        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
   

    // Update is called once per frame

}
