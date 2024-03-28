using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class HouseScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    RectTransform rectTransform;
    Image image;
    [SerializeField] GameObject visualCue, canvasToOpen, inventoryPanel;
    [SerializeField] float offSet;
    bool inRange, openInteractible;

   
    

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(255, 255, 255, 150) ;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition += eventData.delta;

        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(255, 255, 255, 255);
    }

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }


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
            inventoryPanel.SetActive(true);
        }
        else if (!openInteractible && inRange)
        {
            CharacterMovements.instance.EnableCharacterMovement(true);
            canvasToOpen.SetActive(false);
            inventoryPanel.SetActive(true);
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
