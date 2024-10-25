using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float playerHealth = 100;

    public TextMeshProUGUI HealthIndication;

    public float PlayerHealth
    {
        get { return playerHealth; }
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

            playerHealth = value;
        }
    }

    private void Update()
    {
        HealthIndication.text = "HP = " + PlayerHealth.ToString();
    }

}
