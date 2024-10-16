using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // ammunition capacity of some amount
    [SerializeField] private int ammunitionCurrent;
    [SerializeField] private int ammunitionMax;

    // set up a common things that ALL weapons have 
    // thing like
    // shoot 
    public virtual void Shoot()
    {
      if (HasEnoughAmmo())
        {
            // shoot...
        }
      

    }

    public bool HasEnoughAmmo()
    {
        if (ammunitionCurrent > 0)
        {
            ammunitionCurrent--;
            Debug.Log("Firing the " + gameObject.name + "!");
            return true;
        }
        else
        {
            //No ammo!
            Debug.Log("No ammunition on " + gameObject.name + "!");
            return false;
        }
        // shoot...
    }

    // reload 
    public void Reload()
    {
        ammunitionCurrent = ammunitionMax;
    }
    // damages something/makes an impact
    
}
