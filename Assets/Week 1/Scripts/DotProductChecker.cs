using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductChecker : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check the directions of both characters to see if theyre are facing the same way
        // If our dot product is 1 theyre facing the same way
        // -1 = facing oppoisite directions
        // 0 = facing Perpendicular direction

        if (Vector3.Dot(player.transform.forward, enemy.transform.forward) > 0.5)
        {
            Debug.Log("Facing the same way!");
        }
        if (Vector3.Dot(player.transform.forward, enemy.transform.forward) < 0.5)
        {
            Debug.Log("Facing Opposite Direction!");
        }
        if (Vector3.Dot(player.transform.forward, enemy.transform.forward) < 0.5 && Vector3.Dot(player.transform.forward, enemy.transform.forward) > -0.5)
        {
            Debug.Log("Facing Perpendicular!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(player.transform.position, player.transform.position + player.transform.forward);
        Gizmos.DrawLine(enemy.transform.position, enemy.transform.position + enemy.transform.forward);
    }
}
