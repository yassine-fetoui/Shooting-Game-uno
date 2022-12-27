using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneAttacking : enemyAttaking 
{
    public GameObject bulletPrefab;
    public Transform fireSpamPoint;
    public float fireRate = 0.25f;
    public float nextBullet = 0f; 
    // Start is called before the first frame update
    public override void Attack()
    {
        if(Time.time > nextBullet)
        {
            nextBullet = Time.time + fireRate;
            GameObject bullet = Instantiate(bulletPrefab, fireSpamPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * 25 ;
            bullet.GetComponent<bulletDestroy>().targetshooting = "playerF";
          
            bullet.GetComponent<bulletDestroy>().target = bulletDestroy.targetToDestroy.player;

        }

    }
}
