using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    [SerializeField] List<ItemData> requestedRecipe;
    [SerializeField] GameObject visualCue, canvasToOpen;
    [SerializeField] float offSet;
    bool inRange, openInteractible;

    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange && !CanvasManager.instance.CurrentEscapeMenuState())
        {
            canvasToOpen.SetActive(true);
            CharacterMovements.instance.EnableCharacterMovement(false);
            RecipeScript.instance.NewRecipe(requestedRecipe);
            //openInteractible = !openInteractible;
        }

        if (canvasToOpen.active == true && Input.GetMouseButtonDown(0))
        {
            canvasToOpen.SetActive(false);
            CharacterMovements.instance.EnableCharacterMovement(true);
        }
        //if (openInteractible)
        //{
        //    CharacterMovements.instance.EnableCharacterMovement(false);
        //    canvasToOpen.SetActive(true);
        //}
        //else if (!openInteractible && inRange)
        //{
        //    CharacterMovements.instance.EnableCharacterMovement(true);
        //    canvasToOpen.SetActive(false);
        //}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            visualCue.SetActive(true);
            visualCue.GetComponent<RectTransform>().anchoredPosition = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + gameObject.GetComponent<SpriteRenderer>().size.y + offSet));
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
            visualCue.GetComponent<RectTransform>().anchoredPosition = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + gameObject.GetComponent<SpriteRenderer>().size.y + offSet));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            visualCue.SetActive(false);
        }
    }
}
