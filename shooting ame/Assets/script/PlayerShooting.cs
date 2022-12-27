using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator PalyerAnimator;
    public GameObject bulletPrefab;
    public float fireRate = 0.25f;
    public Transform fireSpamPoint;
    private float  nextBullet=0 ;
    private void Awake()
    {
        PalyerAnimator=GetComponentInChildren<Animator>();
    }
    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            PalyerAnimator.SetBool("fire", true);
            if(Time.time > nextBullet)
            {
                nextBullet = Time.time + fireRate ;
                GameObject bullet= Instantiate(bulletPrefab, fireSpamPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = transform.forward*20;
                bullet.GetComponent<bulletDestroy>().targetshooting = "cc";
                bullet.GetComponent<bulletDestroy>().target = bulletDestroy.targetToDestroy.Enemy  ;

            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            PalyerAnimator.SetBool("fire", false);
        }
    }

}
