using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] List<Image> spritesInventory = new List<Image>();
    List<ItemData> inventory = new List<ItemData>();
    int money;

    public static InventoryScript instance;

    private void Awake()
    {
        instance = this;
        for (int i = 0; i < spritesInventory.Count; i++)
        {
            spritesInventory[i].enabled = false;
        }
    }

    public void AddToInvetory(ItemData itemToAdd)
    {
        Debug.Log(itemToAdd.name);
        inventory.Add(itemToAdd);
        UpdateInventory();
    }

    public void UpdateInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(inventory[i].icon.name);
            spritesInventory[i].enabled = true;
            spritesInventory[i].sprite = inventory[i].icon;
            
        }
    }
}
