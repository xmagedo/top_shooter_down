using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float bulletLifetime = 2f;

    void Start()
    {
        Destroy(gameObject, bulletLifetime);
    }

    void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Enemy"))
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}

}