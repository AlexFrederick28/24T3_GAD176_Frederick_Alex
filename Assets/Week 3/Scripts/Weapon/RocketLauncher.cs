using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Weapon
{

    [SerializeField] private GameObject rocketPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
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
            GameObject newRocket = Instantiate(rocketPrefab, transform.position, Quaternion.identity);
        }

    }
}
