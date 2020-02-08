using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAnger : MonoBehaviour
{
    public float offset = 0;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject bulletStop;
    private float timeBtwShots;
    public float startTimeBtwShots;
    private int offset1= -1;
    private int offset2 = 180;
    private int randomNum;
    private bool flag;
    private float secs = 1000f;
    private bool secondflag;
    public Transform Holder;

    private void Start()
    {
        flag = true;
        secondflag = true;
    }
    void Update()
    {
                if (flag == true)
                {
                    randomNum = Random.Range(1, 40 + 1);
                    if (randomNum >= 1 && randomNum <=5)
                    {
                        offset =360;
                        flag = false;
                    }

                    if(randomNum >= 6 && randomNum <= 10)
                    {
                        flag = false;
                    }
                    if (randomNum >= 11 && randomNum <= 15)
                    {
                        flag = false;
                    }
                    if (randomNum >= 16 && randomNum <= 20)
                    {
                        flag = false;
                    }
                    if (randomNum >= 21 && randomNum <= 25)
                    {
                        flag = false;
                    }
                    if (randomNum >= 26 && randomNum <= 30)
                    {
                        flag = false;
                    }
                    if (randomNum >= 31 && randomNum <= 35)
                    {
                        flag = false;
                    }
                    if (randomNum >= 36 && randomNum <= 40)
                    {
                        flag = false;
                    }
                }


                    if (randomNum >= 1 && randomNum <= 5)
                    {
                        secs--;
                        Spiral();
                        Timer();
                    }

                    if (randomNum >= 6 && randomNum <= 10)
                    {
                        secs--;
                        Spread();
                        Timer();
                    }
                    if (randomNum >= 11 && randomNum <= 15)
                    {
                        secs--;
                        SpiralSer();
                        Timer();
                    }
                    if (randomNum >= 16 && randomNum <= 20)
                    {
                        secs--;
                        SpreadSer();
                        Timer();
                    }
                    if (randomNum >= 21 && randomNum <= 25)
                    {
                        secs--;
                        Spinning();
                        Timer();
                    }
                    if (randomNum >= 26 && randomNum <= 30)
                    {
                        secs--;
                        SpinningRev();
                        Timer();
                    }
                    if (randomNum >= 31 && randomNum <= 35)
                    {
                        secs--;
                        SpiralRev();
                        Timer();
                    }
                    if (randomNum >= 36 && randomNum <= 40)
                    {
                        secs--;
                        SpiralSerRev();
                        Timer();
                    }


    }
    void Timer()
    {
        
        if (secs <=0)
        {
            randomNum = 0;
            flag = true;
            secs = 1000f;
            offset = 0f;
        }
    }

    void SpinningRev()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        offset++;

        if (offset >= 360f)
        {
            offset = -360f;
        }
        if (timeBtwShots <= 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 30f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 60f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 90f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 120f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 150f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 180f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 210f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 240f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 270f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 300f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 330f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 360f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }
    void SpiralRev()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        offset++;

        if (offset >= 360f)
        {
            offset = -360f;
        }

        if (timeBtwShots <= 0)
        {
            Shoot();
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }
    void SpiralSerRev()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        offset++;

        if (offset >= 360f)
        {
            offset = -360f;
        }

        if (timeBtwShots <= 0)
        {
            Instantiate(bulletStop, firePoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }
    void SpiralSer()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        offset--;

        if (offset <= -360f)
        {
            offset = 360f;
        }

        if (timeBtwShots <= 0)
        {
            Instantiate(bulletStop, firePoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }
    void SpreadSer()
    {
        
            transform.rotation = Quaternion.Euler(0f, 0f, offset);

            if (offset >= offset1 && offset <= offset2 && secondflag == true)
            {
                offset++;
            }

            if (offset == offset2)
                secondflag = false;

            if (secondflag == false)
            {
                offset--;
            }

            if (offset == offset1)
                secondflag = true;

            if (timeBtwShots <= 0)
            {
                Instantiate(bulletStop, firePoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            else
                timeBtwShots -= Time.deltaTime;
        
    }
    void Spread()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        if (offset >= offset1 && offset <= offset2 && secondflag == true)
        {
            offset++;
        }

        if (offset == offset2)
            secondflag = false;

        if (secondflag == false)
        {
            offset--;
        }

        if (offset == offset1)
            secondflag = true;

        if (timeBtwShots <= 0)
        {
            Shoot();
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }
    void Spiral()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);
        
        offset--;

        if (offset <= -360f)
        {
            offset = 360f;
        }

        if (timeBtwShots <= 0)
        {
            Shoot();
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;

    }

    void Spinning()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        offset--;

        if (offset <= -360f)
        {
            offset = 360f;
        }
        if (timeBtwShots <= 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 30f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 60f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 90f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 120f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 150f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 180f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 210f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 240f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 270f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 300f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 330f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            transform.rotation = Quaternion.Euler(0f, 0f, offset + 360f);
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
    }

    
}
