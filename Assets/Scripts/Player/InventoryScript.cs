using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] List<Image> spritesInventory = new List<Image>(), spritesHouseInventory = new List<Image>();
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
        for (int i = 0; i < spritesHouseInventory.Count; i++)
        {
            spritesHouseInventory[i].enabled = false;
        }
    }

    public void AddToInventory(ItemData itemToAdd)
    {
        Debug.Log(itemToAdd.name);
        inventory.Add(itemToAdd);
        UpdateInventory();
        UpdateHouseInventory();
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

    public void UpdateHouseInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(inventory[i].icon.name);
            spritesHouseInventory[i].enabled = true;
            spritesHouseInventory[i].sprite = inventory[i].icon;
            
        }
    }

    public void SetScriptsOnItems()
    {
        Debug.Log("assagning Scripts");
       for(int i = 0;i < inventory.Count;i++)
       {
            spritesHouseInventory[i].AddComponent<DragAndDropScript>();
            spritesHouseInventory[i].AddComponent<ItemShopScript>().AddData(inventory[i]);
        }
    }
    public void RemoveFromInventory(ItemData itemToRemove)
    {
        inventory.Remove(itemToRemove);
        UpdateInventory();
        UpdateHouseInventory();
    }
}


