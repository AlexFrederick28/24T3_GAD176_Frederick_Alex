using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    public EnemyStats enemyStats;

    
    void Update()
    {
        if (rb == null) // gets scripts automatically
        {
            enemyStats = FindObjectOfType<EnemyStats>();
            rb = GetComponent<Rigidbody>();
        }


        rb.AddForce(transform.forward * 10); // bullet gets propelled forward

        Destroy(gameObject, 2); // destroys itself after a delay of 2 seconds


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyStats>()) // if it hits an enemy it will deal 20 damage and destroy itself
        {
            enemyStats.EnemyHealth -= 20;

            Destroy(gameObject);
        }
    }
}
