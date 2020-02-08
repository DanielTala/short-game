using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHoldEnemy : MonoBehaviour
{
    public float offset;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private Transform target;
    public float AttackRadius;
    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {


        if (timeBtwShots <= 0)
        {

            if (Vector2.Distance(transform.position, target.position) < AttackRadius)
            {

                Shoot();
                timeBtwShots = startTimeBtwShots;

            }
        }
        else
            timeBtwShots -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
    }
}
