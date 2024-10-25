using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rb;

    public EnemyStats enemyStats;

    // Update is called once per frame
    void Update()
    {
        if (rb == null) // gets scripts automatically
        {
            enemyStats = FindObjectOfType<EnemyStats>();
            rb = GetComponent<Rigidbody>();
        }


        rb.AddForce(transform.forward * 10); // rocket gets propelled forward 

        Destroy(gameObject, 2); // destroys itself after a delay of 2 seconds


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyStats>()) // if it hits an enemy it will deal 80 damage and destroy itself
        {
            enemyStats.EnemyHealth -= 80;

            Destroy(gameObject);
        }
    }
}
