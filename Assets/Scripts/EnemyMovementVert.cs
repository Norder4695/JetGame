using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementVert : MonoBehaviour
{
    public CurvedMovementParameters parameters;
    public float initialX;
    public float time;
    Vector3 startPos; // Store the initial position

    private void Start()
    {
        time = Time.time;
    }

    private void Update()
    {
        Vector3 newPosition = transform.position;

        // Move vertically (downward)
        newPosition.y -= Time.deltaTime * parameters.speed * 2;

        // Update the object's position
        transform.position = newPosition;

        Debug.Log(transform.position);
    }
}
