using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public PlayerStats playerStats;

    [SerializeField] protected AudioSource AudioSource;
    [SerializeField] protected AudioClip sfx1, sxf2;

    protected virtual void SeenPlayer()
    {

        AudioSource.clip = sfx1;
        AudioSource.Play();

    }

}
