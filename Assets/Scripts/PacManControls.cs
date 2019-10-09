using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManControls : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        
        Rigidbody2D rBody =GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(horiz * speed, vert * speed);

    }
}
