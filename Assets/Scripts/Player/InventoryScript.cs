using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] List<UnityEngine.UI.Image> spritesInventory = new List<UnityEngine.UI.Image>();
    [SerializeField] List<GameObject> spritesHouseInventory = new List<GameObject>();
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
            spritesHouseInventory[i].GetComponent<Image>().enabled = false;
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

    public void AddToHouseInvetory(ItemData itemToAdd)
    {
        Debug.Log(itemToAdd.name);
        inventory.Add(itemToAdd);
        UpdateHouseInventory();
    }

    public void UpdateHouseInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(inventory[i].icon.name);
            spritesHouseInventory[i].GetComponent<Image>().enabled = true;
            spritesHouseInventory[i].GetComponent<Image>().sprite = inventory[i].icon;
            spritesHouseInventory[i].AddComponent<DragAndDropScript>();
            spritesHouseInventory[i].AddComponent<ShopScript>(inventory[i]); 

        }
    }

    public void RemoveFromInventory(ItemData itemToRemove)
    {
        inventory.Remove(itemToRemove);
        UpdateInventory();
        UpdateHouseInventory();
    }
}


