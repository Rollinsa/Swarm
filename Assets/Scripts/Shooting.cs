using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    [SerializeField] public float bulletForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Spawn a bullet at firepoint, with rotation equal to the player's rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, gameObject.transform.rotation);
        // Rotate the bullet so that it's always coming out sideways
        bullet.transform.Rotate(0f, 0f, 90f, Space.Self);

        // Shoot the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
