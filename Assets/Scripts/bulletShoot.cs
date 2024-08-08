using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint1;
    public Transform bulletSpawnPoint2;
    public Transform bulletSpawnPoint3;
    public Transform bulletSpawnPoint4;
    public float bulletSpeed = 15f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //create instance of a bullet
            var bullet1 = Instantiate(bulletPrefab,bulletSpawnPoint1.position,bulletSpawnPoint1.rotation);
            var bullet2 = Instantiate(bulletPrefab,bulletSpawnPoint2.position,bulletSpawnPoint2.rotation);
            var bullet3 = Instantiate(bulletPrefab, bulletSpawnPoint3.position, bulletSpawnPoint3.rotation);
            var bullet4 = Instantiate(bulletPrefab, bulletSpawnPoint4.position, bulletSpawnPoint4.rotation);

            //create velocity for the bullets
            bullet1.GetComponent<Rigidbody>().velocity = bulletSpawnPoint1.forward*bulletSpeed;
            bullet2.GetComponent<Rigidbody>().velocity = bulletSpawnPoint2.right*bulletSpeed;
            bullet3.GetComponent<Rigidbody>().velocity = -bulletSpawnPoint3.forward * bulletSpeed;
            bullet4.GetComponent<Rigidbody>().velocity = -bulletSpawnPoint4.right * bulletSpeed;
        }
    }

    
}
