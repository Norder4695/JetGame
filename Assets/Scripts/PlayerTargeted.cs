using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTargeted : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemies_spawner enemies_Spawner;
    public TMP_Text gameOverText;
    void Start()
    {
        enemies_Spawner = GameObject.FindObjectOfType<Enemies_spawner>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy the object when it hits the bottom of the screen
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemies_Spawner.isPlayerAlive = false;
            gameOverText.text = "Game over ";
        }
    }
}
