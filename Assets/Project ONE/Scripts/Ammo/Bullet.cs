using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    public EnemyStats enemyStats;

    
    void Update()
    {
        if (rb == null)
        {
            enemyStats = FindObjectOfType<EnemyStats>();
            rb = GetComponent<Rigidbody>();
        }


        rb.AddForce(transform.forward * 10);

        Destroy(gameObject, 2);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyStats>())
        {
            enemyStats.EnemyHealth -= 20;

            Destroy(gameObject);
        }
    }
}
