using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // components
    Rigidbody2D rigidbody;

    public float jumpForce;
    public bool grounded;
    public bool groundCheck;
    bool jumpReady;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        jumpReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            jumpReady = true;
        }
        if (jumpReady && grounded)
        {
            rigidbody.AddForce(transform.up * jumpForce);
            jumpReady = false;
        }
        if (rigidbody.velocity.y < -0.1)
        {
            rigidbody.velocity += Vector2.up * Physics2D.gravity.y * 5f * Time.deltaTime;
        }
    }
}