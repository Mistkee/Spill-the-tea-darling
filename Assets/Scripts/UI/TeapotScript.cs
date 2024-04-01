using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotScript : MonoBehaviour
{

    List<ItemData> requestedRecipe = new List<ItemData>(), addedIngredients = new List<ItemData>();

    private void Start()
    {
        InventoryScript.instance.SetScriptsOnItems();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ItemShopScript>() == true)
        {
            InventoryScript.instance.RemoveFromInventory(other.GetComponent<ItemData>());
            addedIngredients.Add(other.GetComponent<ItemShopScript>().data);
        }
        Debug.Log(addedIngredients.Count);
    }
}
