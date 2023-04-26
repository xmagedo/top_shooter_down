using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed = 10f;
    private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _direction * bulletSpeed * Time.deltaTime;
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;
    }
}
