using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    GameObject recipePanel;
    int itemsAvailable;

    private void Awake()
    {
        recipePanel = GameObject.Find("Recipe Panel");
    }
    private void Start()
    {
        itemsAvailable = 5;
    }

    public void ItemBought(GameObject button)
    {
        
        if (itemsAvailable > 0)
        {
            itemsAvailable--;
            InventoryScript.instance.AddToInvetory(button.GetComponent<ItemShopScript>().data);
            InventoryScript.instance.AddToHouseInvetory(button.GetComponent<ItemShopScript>().data);
        }
        else
        {
            Debug.Log("You can't buy anything else today");
        }
       
    }

    public void Displayrecipes()
    {
        recipePanel.SetActive(true);
    }
}
