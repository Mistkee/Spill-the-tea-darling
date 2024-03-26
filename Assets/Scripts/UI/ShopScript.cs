using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{

   

    public void ItemBought(GameObject button)
    {
        Debug.Log(button.GetComponent<ItemShopScript>().data.name);
        InventoryScript.instance.AddToInvetory(button.GetComponent<ItemShopScript>().data);
    }
}
