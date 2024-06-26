using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDropScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    RectTransform rectTransform;
    Image image;
    BoxCollider collider;

    public void OnBeginDrag(PointerEventData eventData)
    {
       
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        collider.enabled = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {


        collider.enabled = true;
    }

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        collider = GetComponent<BoxCollider>();
    }
}
