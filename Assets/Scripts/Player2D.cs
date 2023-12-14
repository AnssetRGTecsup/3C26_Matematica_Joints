using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public Joint2D joint;

    Vector2 input;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        input = new Vector2(x, 0);
    }

    void FixedUpdate()
    {
        Vector2 move = input * speed;
        rb.velocity = new Vector2(input.x, rb.velocity.y) * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        joint.enabled = false;
    }
}
