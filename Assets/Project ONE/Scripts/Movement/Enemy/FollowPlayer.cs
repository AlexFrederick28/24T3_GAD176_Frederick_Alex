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
        if (PlayerMovement == null)
        {
            PlayerStats = FindObjectOfType<PlayerStats>();
            PlayerMovement = FindObjectOfType<FPSMovement>();
        }
    }

    private void Update()
    {
        
        MoveToPlayer();
    }

    

    protected void MoveToPlayer()
    {
        chasePlayer = (PlayerMovement.transform.position - transform.position);

        Debug.Log("Enemty is " + chasePlayer.magnitude + " units away!");

        chasePlayer = chasePlayer.normalized;
        transform.position += chasePlayer * Time.deltaTime * moveSpeed;

        transform.LookAt(PlayerMovement.transform);

        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colliding with " + collision.gameObject.name);

        if (collision.gameObject.GetComponent<PlayerStats>())
        {
            Debug.Log("Enemy dealt 20 damage to Player");

            PlayerStats.PlayerHealth -= 20;

            Vector3 moveBack = new Vector3(0, 0, 10);

            transform.position -= moveBack;

            
        }
    }
}
