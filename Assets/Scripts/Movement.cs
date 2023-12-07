using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float velocity = 5f; 
    Rigidbody2D myRB2D;

    private void Start()
    {
        myRB2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        myRB2D.velocity = new Vector2(velocity, myRB2D.velocity.y);
    }
}