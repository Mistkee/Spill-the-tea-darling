using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemShopScript : MonoBehaviour
{
    public ItemData data;

    public void AddData(ItemData newData)
    {
        data = newData;
    }
}
