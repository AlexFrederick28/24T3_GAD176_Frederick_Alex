using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // ammunition capacity of some amount
    [SerializeField] private int ammunitionCurrent;
    [SerializeField] private int ammunitionMax;

    private bool canShoot = true;

    // set up a common things that ALL weapons have 
    // thing like
    // shoot 
    public virtual void Shoot()
    {
      if (HasEnoughAmmo() == true)
        {
            // shoot...
        }

        Debug.Log(AddNumbers(1,2));
    }

    private int AddNumbers(int a, int b) // this is an example
    {
        int result = a + b;

        return result;
    }
   
    protected bool HasEnoughAmmo() // uses protected - can be used while in inherited classes
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
