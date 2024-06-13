using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public CurvedMovementParameters parameters;
    public float initialX;
    public float time;
    Vector3 startPos; // Store the initial position

    private void Start()
    {
        initialX = transform.position.x; // Save the initial position

        time = Time.time;
    }

    private void Update()
    {
        Vector3 newPosition = transform.position;
        // Move horizontally (left/right)
        newPosition.x = initialX + Mathf.Sin((Time.time - time) * parameters.frequency) * parameters.magnitude;

        // Move vertically (downward)
        newPosition.y -= Time.deltaTime * parameters.speed;

        // Update the object's position
        transform.position = newPosition;

        Debug.Log(transform.position);
    }

}
