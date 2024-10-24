using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private float enemyHealth = 100;

    public TextMeshPro EnemyHealthIndication;

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
            Destroy(gameObject);
        }
    }


}
