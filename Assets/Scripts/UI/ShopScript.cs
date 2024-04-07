using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    GameObject recipePanel;
    //int itemsAvailable;

    private void Awake()
    {
        recipePanel = GameObject.Find("Recipe Panel");
    }
    private void Start()
    {
        
    }

    public void ItemBought(GameObject button)
    {
        InventoryScript.instance.AddToInventory(button.GetComponent<ItemShopScript>().data);
        //if (itemsAvailable > 0)
        //{
        //    itemsAvailable--;
            
        //}
        //else
        //{
        //    Debug.Log("You can't buy anything else today");
        //}
       
    }

    public void Displayrecipes()
    {
        recipePanel.SetActive(true);
    }
}
