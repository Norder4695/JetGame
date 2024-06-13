using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Adjust the speed as needed
    public float frequency = 20f; // Adjust the frequency (how fast the sine wave oscillates)
    public float magnitude = 0.5f; // Adjust the magnitude (amplitude) of the sine wave
    public float initialX;
    Vector3 startPos; // Store the initial position

    private void Start()
    {
        initialX = transform.position.x; // Save the initial position
    }

    private void Update()
    {
        Vector3 newPosition = transform.position;
        // Move horizontally (left/right)
        newPosition.x = initialX + Mathf.Sin(Time.time * frequency) * magnitude;

        // Move vertically (downward)
        newPosition.y -= Time.deltaTime * speed;

        // Update the object's position
        transform.position = newPosition;

        Debug.Log(transform.position);
    }
}
