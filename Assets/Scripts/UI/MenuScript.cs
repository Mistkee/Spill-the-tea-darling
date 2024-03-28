using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject menuInventory, inventoryPanel;
    bool isInShop, openMenu;

    private void Start()
    {
        CanvasManager.instance.CanUseEscapeMenu(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && CanvasManager.instance.CurrentUseEscapeMenu())
        {
            openMenu = !openMenu;
            
        }

        if (openMenu)
        {
            CanvasManager.instance.EscapeMenuEnabled(true);

            
            Time.timeScale = 0f;
            menuInventory.SetActive(true);
            
        }
        else if (!openMenu)
        {
            CanvasManager.instance.EscapeMenuEnabled(false);
           
            Time.timeScale = 1f;
            menuInventory.SetActive(false);
            
        }
       
    }

    public void SetInventoryActive()
    {
        inventoryPanel.SetActive(true);
    }

    public void SetInventoryInactive()
    {
        inventoryPanel.SetActive(false);
    }
}
