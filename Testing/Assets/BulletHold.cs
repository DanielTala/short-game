using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHold : MonoBehaviour
{
    public float offset;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
    }
}
