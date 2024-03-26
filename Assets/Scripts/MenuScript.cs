using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject menuInventory;
    bool isInShop, openMenu;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openMenu = !openMenu;
           
        }
    
        if (openMenu)
        {
            Time.timeScale = 0f;
            menuInventory.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            menuInventory.SetActive(false);
        }
    }
}
