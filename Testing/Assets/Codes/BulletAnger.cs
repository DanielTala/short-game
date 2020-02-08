using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAnger : MonoBehaviour
{
    private float speed = 5f;
    private float secs = 0f;
    private bool flag= true;
    void Start()
    {

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

    }




}
