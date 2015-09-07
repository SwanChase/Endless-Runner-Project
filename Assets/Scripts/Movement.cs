using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float Test;
    public float speed;

    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(1.0f, 0.0f, moveVertical);

        rb.AddForce(movement * speed/*,ForceMode2D.Impulse*/);
    }
}
