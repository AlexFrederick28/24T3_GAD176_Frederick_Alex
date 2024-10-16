using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
    public override void Shoot()
    {
        

        if (HasEnoughAmmo())
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

        
    }
}
