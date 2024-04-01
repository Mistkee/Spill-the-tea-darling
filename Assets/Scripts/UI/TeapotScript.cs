using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotScript : MonoBehaviour
{
    public List<ItemData> rightRecipe = new List<ItemData>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<ItemData>() == true)
        {
            InventoryScript.instance.RemoveFromInventory(collision.GetComponent<ItemData>());
            rightRecipe.Add(collision.GetComponent<ItemData>());
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.GetComponent<ItemData>() == true)
    //    {
    //        InventoryScript.instance.RemoveFromInventory(other.GetComponent<ItemData>());
    //        rightRecipe.Add(other.GetComponent<ItemData>());
    //    }
    //}
}
