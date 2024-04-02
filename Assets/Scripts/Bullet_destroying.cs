using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_destroying : MonoBehaviour
{
    // Start is called before the first frame update

    public float topBound = 5.0f; // Adjust this value to match your scene's top boundary
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
