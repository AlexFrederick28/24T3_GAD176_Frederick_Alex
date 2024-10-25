using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour, IWeaponInterface
{
    
    [SerializeField] private GameObject rocketBullet;
    [SerializeField] private int ammo;
    private int RocketAmmo
    {
        get { return ammo; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            ammo = value;
        }
    }

    public int AmmoConsumption()
    {

        if (Input.GetMouseButtonDown(1) && ammo != 0)
        {
            RocketAmmo--;

            Instantiate(rocketBullet, transform.position, transform.rotation);

            Debug.Log("Shooting " + gameObject);
        }
        if (RocketAmmo == 0)
        {
            Debug.Log(gameObject + " Empty!");
        }

        return RocketAmmo;
    }

    public int MaxAmmo()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RocketAmmo = 1;
            Debug.Log("Reloaded!");
        }
        return RocketAmmo;
    }


    public void Update()
    {
        AmmoConsumption();
        MaxAmmo();

    }
}
