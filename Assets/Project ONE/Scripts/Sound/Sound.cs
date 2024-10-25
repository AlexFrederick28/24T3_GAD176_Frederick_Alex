using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public PlayerStats playerStats;

    [SerializeField] protected AudioSource AudioSource;
    [SerializeField] protected AudioClip sfx1, sxf2;

    protected virtual void SeenPlayer() // use function in inherited scripts to enable sounds (Plays when a player is spotted)
    {

        AudioSource.clip = sfx1;
        AudioSource.Play();

    }

}
