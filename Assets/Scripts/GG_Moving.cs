using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG_Moving : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = gameObject.transform.position;
    }
    void FixedUpdate()
    {
        Flip();
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

    }
    void Flip()
    {
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
}
