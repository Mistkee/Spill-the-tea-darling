using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeapotScript : MonoBehaviour
{
    [SerializeField] GameObject winPanel, loosePanel;
    List<ItemData> requestedRecipe = new List<ItemData>(), addedIngredients = new List<ItemData>();
    bool lost;
   
    private void Start()
    {
        InventoryScript.instance.SetScriptsOnItems();
        requestedRecipe = RecipeScript.instance.TakeRecipe();
        lost = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ItemShopScript>() == true)
        {
            //InventoryScript.instance.RemoveFromInventory(other.GetComponent<ItemShopScript>().data);
            addedIngredients.Add(other.GetComponent<ItemShopScript>().data);
            SucessRecipe();
            
           
            
            Destroy(other.gameObject);
            
        }
    }

    void SucessRecipe()
    {
        if(addedIngredients.Count == requestedRecipe.Count)
        {
            foreach (ItemData item in addedIngredients)
            {
                if (!requestedRecipe.Contains(item))
                {
                   loosePanel.SetActive(true);
                    lost = true;
                }
            }
            if (!lost)
            {
                winPanel.SetActive(true);
            }
            
        }
        
    }

    public void YouWon()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void YouLost()
    {
        SceneManager.LoadScene("GameScene");
    }
}
