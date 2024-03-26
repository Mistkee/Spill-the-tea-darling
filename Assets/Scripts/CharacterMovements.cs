using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovements : MonoBehaviour
{
    [SerializeField] float speed, jump;
    Rigidbody2D rb;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
           rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }

        if (rb.velocity.y < 0)
        {
            rb.gravityScale = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            rb.gravityScale = 1;
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            isGrounded = false;
        }
    }
}
