using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : Sound
{
    [SerializeField] private float enemyHealth = 100;

    public TextMeshPro EnemyHealthIndication;

    public SpawnEnemies spawnEnemies;

    public float EnemyHealth
    {
        get { return enemyHealth; }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            if (value < 0)
            {
                value = 0;
            }

            enemyHealth = value;
        }
    }

    private void Update()
    {
        
        EnemyHealthIndication.text = EnemyHealth.ToString();

        if (enemyHealth == 0)
        {
            spawnEnemies.SpawnedEnemies.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        if (spawnEnemies == null)
        {
            spawnEnemies = FindObjectOfType<SpawnEnemies>();
        }

        spawnEnemies.SpawnedEnemies.Add(gameObject);

        SeenPlayer();
    }

    protected override void SeenPlayer()
    {
        AudioSource.volume = 0.05f;
        base.SeenPlayer();
    }

    
}
