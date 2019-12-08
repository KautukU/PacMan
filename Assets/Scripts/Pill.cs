using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "pacman")
        {
            other.gameObject.GetComponent<Controls>().score += 100;
            Destroy(gameObject);
        }
        
    }
}
