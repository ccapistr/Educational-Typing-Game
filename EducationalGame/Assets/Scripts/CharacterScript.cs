using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    public bool isGrounded = false;
    


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Jump();

        float move = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(speed * move, rb2d.velocity.y);

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true) //Method allows player to jump by pressing space button and checks to make sure player is on the ground
        {
           gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }


    }



}
