using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Enemies_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyFalling;
    public GameObject Pause;
    public int score = 0;
    public float spawnInterval = 1.0f;
    public bool isPlayerAlive = true;
    public Score_timer score_Timer;
    public Spaceship_movement spaceship_Movement;
    public bool isPaused = false;

    void Start()
    {
        StartCoroutine(SpawnFallingObject());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
            Pause.SetActive(true);
            spaceship_Movement.speed = 0f;
        }
    }


    private IEnumerator SpawnFallingObject()
    {
        while (isPlayerAlive == true)
        {
            // Instantiate the object at a random position at the top of the screen
            Vector3 spawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), 5.32f, 0);
            GameObject enemyInstance = Instantiate(enemyFalling, spawnPosition, Quaternion.identity);

            // Wait for the next spawn
            yield return new WaitForSeconds(spawnInterval);

            // Stop everyone after the end of the game
            if (isPlayerAlive == false || isPaused == true)
            {
                Rigidbody2D rbFreeze = enemyInstance.GetComponent<Rigidbody2D>();
                spawnInterval = 10f;
                /*if (rb != null)
                {
                    rbFreeze.constraints = RigidbodyConstraints2D.FreezeAll;
                }
                */
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy the object when it hits the bottom of the screen
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);            
        }
    }
}
