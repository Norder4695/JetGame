using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 origin = new Vector3(-2.5f, 5f, 0f); // Top position
    public Vector3 destination1 = new Vector3(2.5f, 0f, 0f); // Bottom position
    public float movementTime = 5f; // Time in seconds for the movement
    public float frequency = 1f; // Frequency of the sine wave (oscillations per second)
    public float amplitude = 1f; // Amplitude of the sine wave

    private float currentMovementTime = 0f;

    private void Update()
    {
        currentMovementTime += Time.deltaTime;

        // Calculate the position along the sine wave
        float t = currentMovementTime / movementTime;
        float sineValue = Mathf.Sin(2f * Mathf.PI * frequency * t) * amplitude;

        // Apply the sine wave motion vertically
        Vector3 newPosition = origin + Vector3.up * sineValue;

        transform.localPosition = Vector3.Lerp(origin, destination1, t) + newPosition;
    }
}
