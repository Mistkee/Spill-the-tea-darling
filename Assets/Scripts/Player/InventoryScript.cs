using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    List<ItemData> inventory = new List<ItemData>();
    int money;

    public static InventoryScript instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddToInvetory(ItemData itemToAdd)
    {
        inventory.Add(itemToAdd);
    }
}
