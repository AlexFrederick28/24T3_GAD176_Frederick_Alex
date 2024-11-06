using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Start()
    {
        foreach (Item item in items)
        {
            Debug.Log("Item: " + item.name);
        }
    }
}
