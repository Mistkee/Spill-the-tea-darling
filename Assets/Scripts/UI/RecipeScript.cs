using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class RecipeScript : MonoBehaviour
{
    [SerializeField] GameObject recipePanel;
    [SerializeField] List<TextMeshProUGUI> recipeListSlots;
    List<ItemData> requestedRecipe;

    public static RecipeScript instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void NewRecipe(List<ItemData> newRecipe )
    {
        requestedRecipe = newRecipe;
        for (int i = 0; i < newRecipe.Count; i++)
        {
            if(newRecipe[i] != null )
            {
                recipeListSlots[i].text = "" + newRecipe[i].namee;
            }
            
        }
    }

    public List<ItemData> TakeRecipe()
    {
        return requestedRecipe;
    }
    public void DisplayRecipes()
    {
        recipePanel.SetActive(true);

    }

    public void CloseRecipes()
    {
        recipePanel.SetActive(false);
    }
}
