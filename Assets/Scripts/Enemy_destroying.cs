using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroying : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the enemy
        }
    }
}
