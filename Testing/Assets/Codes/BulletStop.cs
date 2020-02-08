using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStop : MonoBehaviour
{
    private float speed = 5f;
    private float secs = 0f;
    private bool flag = true;
    void Start()
    {

    }

    void Update()
    {
        secs++;
        Debug.Log(speed);
        Timer();
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }


    void Timer()
    {
        if (secs >= 10f && flag == true)
        {
            speed = 0f;
            flag = false;
        }
        if (secs >= 50f)

        {
            speed = 10f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }

    }

}
