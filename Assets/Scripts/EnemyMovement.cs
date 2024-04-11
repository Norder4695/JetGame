using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Vector3 origin;
    public Vector3 destination1;
    public Vector3 destination2;
    public float movementTime = 5f; // Time in seconds for the movement
    public GameObject Enemy;

    private float currentMovementTime = 0f;

    private void Update()
    {
        currentMovementTime += Time.deltaTime;
        transform.localPosition = Vector3.Lerp(origin, destination1, currentMovementTime / movementTime);
    }
}
