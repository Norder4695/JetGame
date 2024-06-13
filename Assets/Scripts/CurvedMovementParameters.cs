using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new curved movement settings", menuName = "my game/sidescroller/curved movement settings")]
public class CurvedMovementParameters : ScriptableObject
{
    public float speed = 1f; // Adjust the speed as needed
    public float frequency = 0.5f; // Adjust the frequency (how fast the sine wave oscillates)
    public float magnitude = 0.5f; // Adjust the magnitude (amplitude) of the sine wave
}
