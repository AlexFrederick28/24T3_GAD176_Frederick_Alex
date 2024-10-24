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
            enemyStats.EnemyHealth -= 80;

            Destroy(gameObject);
        }
    }
}
