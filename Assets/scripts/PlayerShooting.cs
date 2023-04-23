using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
  public GameObject bulletPrefab;
public Transform bulletSpawnPoint;
public float fireRate;
private float nextFireTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void ShootBullet()
{
    Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
}


    // Update is called once per frame
   void Update()
{
    if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime)
    {
        ShootBullet();
        nextFireTime = Time.time + fireRate;
    }
}
}


