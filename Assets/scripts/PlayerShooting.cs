using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float fireRate;
    private float nextFireTime;

    void ShootBullet(Vector3 direction)
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<BulletMovement>().SetDirection(direction);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime)
        {
            GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
            if (enemy != null)
            {
                Vector3 direction = enemy.transform.position - transform.position;
                direction.Normalize();

                ShootBullet(direction);
                nextFireTime = Time.time + fireRate;
            }
        }
    }
}
