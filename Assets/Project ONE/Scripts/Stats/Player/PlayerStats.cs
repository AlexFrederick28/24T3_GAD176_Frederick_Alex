using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float playerHealth = 100; // player health

    public TextMeshProUGUI HealthIndication;

    public float PlayerHealth // ensures that the player health cannot go below 0 or above 100
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

    private void Update() // text showing player health at all times
    {
        HealthIndication.text = "HP = " + PlayerHealth.ToString();
    }

}
