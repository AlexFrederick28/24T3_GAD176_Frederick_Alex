using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour, IWeaponInterface
{

    [SerializeField] private int ammo;
    private int PistolAmmo
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

        if (Input.GetMouseButtonDown(0) && ammo != 0)
        {
            PistolAmmo--;
            Debug.Log("Shooting " + gameObject);
        }
        if (PistolAmmo == 0)
        {
            Debug.Log(gameObject + " Empty!");
        }

        return PistolAmmo;
    }

    public int MaxAmmo()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PistolAmmo = 5;
            Debug.Log("Reloaded!");
        }
        return PistolAmmo;
    }

    public bool Reload()
    {
       
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        AmmoConsumption();
        MaxAmmo();
    }
}