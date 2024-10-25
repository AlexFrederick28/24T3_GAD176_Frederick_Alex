using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject spawnEnemy;
    public EnemyStats enemyStats;

    public List<GameObject> SpawnedEnemies = new List<GameObject>();

    public void Update()
    {
        if (enemyStats == null) // gets scripts automatically
        {
            enemyStats = FindObjectOfType<EnemyStats>();
        }
        if (SpawnedEnemies.Count == 0) // if there are no enemies in the scene, spawn one
        {
            Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        }
    }
}
