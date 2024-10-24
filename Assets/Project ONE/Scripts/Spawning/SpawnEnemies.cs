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
        if (enemyStats == null)
        {
            enemyStats = FindObjectOfType<EnemyStats>();
        }
        if (SpawnedEnemies.Count == 0)
        {
            Instantiate(spawnEnemy, transform.position, Quaternion.identity);
        }
    }
}
