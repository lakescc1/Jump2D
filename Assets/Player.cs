using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 jumpForce = new Vector2(0, 7);
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.anyKeyDown)
            rb.AddForce(jumpForce, ForceMode2D.Impulse);
    }
}
