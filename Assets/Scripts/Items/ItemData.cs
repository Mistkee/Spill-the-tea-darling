using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shop Item", menuName = "New Shop Item", order = 1)]
public class ItemData : ScriptableObject
{
    
    public string iD;
    public Sprite icon;
    public string name;
    public float cost;
}
