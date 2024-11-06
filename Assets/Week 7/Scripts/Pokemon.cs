using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Game Freak Plagiarism/Pokemon")]
public class Pokemon : ScriptableObject
{
    public int pokedexNum;
    public string name;
    public string type1;
    public string type2;
    public int evolutionStage;
    public Sprite icon;
    public float weight;
    
}
