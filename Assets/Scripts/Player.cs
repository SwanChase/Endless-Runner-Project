using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{

    //controls players speed
    public float speed = 5f;
    private float _move = 2f;

    private Rigidbody2D rb2d;

    //controls player jump
    public float jumpPower = 430f;


    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump")/* && grounded == true */)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }
    }
    void FixedUpdate()
    {
        _move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(_move * speed, GetComponent<Rigidbody2D>().velocity.y);
    }
}