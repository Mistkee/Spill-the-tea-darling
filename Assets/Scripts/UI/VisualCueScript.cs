using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualCueScript : MonoBehaviour
{
    [SerializeField] GameObject visualCue, canvasToOpen;
    [SerializeField] float offSet;
    bool inRange;

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && inRange)
        {
            CharacterMovements.instance.EnableCharacterMovement(false);
            canvasToOpen.SetActive(true);
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            CharacterMovements.instance.EnableCharacterMovement(true);
            canvasToOpen.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
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
