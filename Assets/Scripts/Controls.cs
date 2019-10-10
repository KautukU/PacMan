using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            direction = Vector2.left;
            rbody.velocity = Vector2.left * speed;
            transform.up = Vector2.left;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction = Vector2.right;
            rbody.velocity = Vector2.right * speed;
            transform.up = Vector2.right;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            direction = Vector2.down;
            rbody.velocity = Vector2.down * speed;
            transform.up = Vector2.down;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            direction = Vector2.up;
            rbody.velocity = Vector2.up * speed;
            transform.up = Vector2.up;
        }

        rbody.velocity = direction * speed;
    }
}
