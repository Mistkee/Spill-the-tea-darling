using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    bool canUseEscapeMenu,escapeMenuEnabled, dialogueEnabled, interactibleEnabled, shopEnabled, recipeEnabled;

    public static CanvasManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void CanUseEscapeMenu(bool canUse)
    {
        canUseEscapeMenu = canUse;
    }

    public void EscapeMenuEnabled(bool escapeMenuState)
    {
        escapeMenuEnabled = escapeMenuState;
    }

    public void DialogueEnabled(bool dialogueState)
    {
        dialogueEnabled = dialogueState;
    }

    public void InteractibleEnabled(bool interactibleState)
    {
        interactibleEnabled = interactibleState;
    }

    public void ShopEnabled(bool shopState)
    {
        shopEnabled = shopState;
    }

    public void RecipeEnabled(bool recipeState)
    {
        recipeEnabled = recipeState;
    }

    public bool CurrentUseEscapeMenu()
    {
        return canUseEscapeMenu;
    }
    public bool CurrentEscapeMenuState()
    { return escapeMenuEnabled; }

    public bool CurrentDialogueState()
    { return dialogueEnabled; }

    public bool CurrentInteractibleState() 
    { return interactibleEnabled; }

    public bool CurrentShopState() 
    {  return shopEnabled; }

    public bool CurrentRecipeState() 
    {  return recipeEnabled; }
}
