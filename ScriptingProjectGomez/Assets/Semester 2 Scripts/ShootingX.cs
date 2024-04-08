using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingX : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    private InventoryX inventory;


    private void Awake()
    {
        inventory = GetComponent<InventoryX>();
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if(Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
        }
    }
}
