using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public FPSMovement PlayerMovement;
    public PlayerStats PlayerStats;

    private Vector3 chasePlayer;

    [SerializeField] private float moveSpeed;

    private void Start()
    {
        if (PlayerMovement == null) // gets scripts automatically
        {
            PlayerStats = FindObjectOfType<PlayerStats>();
            PlayerMovement = FindObjectOfType<FPSMovement>();
        }
    }

    private void Update()
    {
        
        MoveToPlayer(); // uses function to follow player and attack them
    }

    

    protected void MoveToPlayer()
    {
        chasePlayer = (PlayerMovement.transform.position - transform.position); // this object moves to the player from the objects position

        Debug.Log("Enemty is " + chasePlayer.magnitude + " units away!"); // dislplays MAGNITUDE

        chasePlayer = chasePlayer.normalized; // normalises the units
        transform.position += chasePlayer * Time.deltaTime * moveSpeed; // starting chase action / movement

        transform.LookAt(PlayerMovement.transform); // makes object face player at all times

        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colliding with " + collision.gameObject.name); // mentions what its colliding with

        if (collision.gameObject.GetComponent<PlayerStats>()) // deals damage to player when hitting its collider, then gets pushed backward
        {
            Debug.Log("Enemy dealt 20 damage to Player");

            PlayerStats.PlayerHealth -= 20;

            Vector3 moveBack = new Vector3(0, 0, 10);

            transform.position -= moveBack;

            
        }
    }
}
