using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GG_Moving : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Animator anim;
    public float x;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.position = gameObject.transform.position;
    }
    void FixedUpdate()
    {
        
        Flip();
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (rb.velocity.x != 0)
            anim.SetInteger("is_running", 1);
        if (rb.velocity.x == 0)
            anim.SetInteger("is_running", 0);
    }

    void Flip()
    {
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
}
