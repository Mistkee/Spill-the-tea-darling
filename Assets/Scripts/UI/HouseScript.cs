using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class HouseScript : MonoBehaviour
{

    [SerializeField] GameObject visualCue, canvasToOpen;
    [SerializeField] float offSet;
    bool inRange, openInteractible;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange && !CanvasManager.instance.CurrentEscapeMenuState())
        {
            openInteractible = !openInteractible;
        }
        if (openInteractible)
        {
            CharacterMovements.instance.EnableCharacterMovement(false);
            canvasToOpen.SetActive(true);
            InventoryScript.instance.SetScriptsOnItems();

        }
        else if (!openInteractible && inRange)
        {
            CharacterMovements.instance.EnableCharacterMovement(true);
            canvasToOpen.SetActive(false);
            
        }

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
