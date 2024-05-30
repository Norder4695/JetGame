using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f; // Adjust the speed as needed
    private Vector3 destination; // Declare the destination variable

    private void Start()
    {
        // Generate random x-coordinate within the specified range
        float randomX = Random.Range(-2.5f, 2.5f); // Adjust the range as needed
        destination = new Vector3(randomX, -5f, 0f); // Set the destination
    }

    private void Update()
    {
        // Move towards the destination
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }
}
