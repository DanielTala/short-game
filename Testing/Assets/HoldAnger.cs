using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAnger : MonoBehaviour
{
    public float offset = 0;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public int offset1= -1;
    public int offset2 = 180;
    private int randomNum;
    private bool flag;
    private float secs = 1000f;
    private bool secondflag;

    private void Start()
    {
        flag = true;
        secondflag = true;
    }
    void Update()
    {
        /*
        Debug.Log(offset);
        transform.rotation = Quaternion.Euler(0f, 0f, offset);

        

        if (offset >=offset1 && offset <= offset2 && secondflag ==true)
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


        /*if (flag == true)
        {
            randomNum = Random.Range(1, 10 + 1);
            if (randomNum == 2)
            {
                offset =360;
                flag = false;
            }
        }
            
            if (randomNum == 2 )
            {
                secs--;
                Spiral();
                Timer();
            }
            
            
        */

        Spiral();

    }
    void Timer()
    {
        
        if (secs <=0)
        {
            randomNum = 1;
            flag = false;

        }
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
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
    }

    
}
