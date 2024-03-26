using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    List<ItemData> inventory;
    int money;
    public static InventoryScript instance;

    private void Awake()
    {
        instance = this;
    }
    public void AddToInvetory(ItemData itemToAdd)
    {
        inventory.Add(itemToAdd);
        Debug.Log(inventory[1].name)
    }
}
