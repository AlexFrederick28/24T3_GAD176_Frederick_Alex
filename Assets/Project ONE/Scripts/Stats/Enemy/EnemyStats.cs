using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : Sound
{
    [SerializeField] private float enemyHealth = 100;

    public TextMeshPro EnemyHealthIndication; // shows enemy health as text

    public SpawnEnemies spawnEnemies;

    public float EnemyHealth // ensures that the player health cannot go below 0 or above 100
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
        
        EnemyHealthIndication.text = EnemyHealth.ToString(); // shows enemy health as text

        if (enemyHealth == 0) // destroys enemy at 0 health
        {
            spawnEnemies.SpawnedEnemies.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        if (spawnEnemies == null) // gets scripts automatically
        {
            spawnEnemies = FindObjectOfType<SpawnEnemies>();
        }

        spawnEnemies.SpawnedEnemies.Add(gameObject);

        SeenPlayer(); // plays sounds
    }

    protected override void SeenPlayer()
    {
        AudioSource.volume = 0.05f; // lowering the volume
        base.SeenPlayer();
    }

    
}
