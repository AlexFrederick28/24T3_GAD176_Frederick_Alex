using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        rb.AddForce(transform.forward * 10);
    }
}
