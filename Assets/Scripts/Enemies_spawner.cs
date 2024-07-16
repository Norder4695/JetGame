using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Enemies_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyFalling;
    public GameObject enemyFalling1;
    public GameObject enemyFalling2;
    public GameObject Pause;
    public int score = 0;
    public float spawnInterval = 1.0f;
    public bool isPlayerAlive = true;
    public Score_timer score_Timer;
    public Spaceship_movement spaceship_Movement;
    public bool isPaused = false;

    void Start()
    {
        StartCoroutine(SpawnEnemies(10));
        StartCoroutine(SpawnEnemies1(5));

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private IEnumerator SpawnEnemies(int numberofEnemies)
    {
        for (int i = 0; i < numberofEnemies; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-1.16f, 1.16f), 5f, 0);
            if (i % 2 == 0)
            {
                Instantiate(enemyFalling, spawnPosition, Quaternion.identity);
            } else Instantiate(enemyFalling1, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);

        }
    }  private IEnumerator SpawnEnemies1(int numberofEnemies)
    {
        for (int i = 0; i < numberofEnemies; i++)
        {
            float spawn;
            if (i % 2 == 0) {
                spawn = 2.26f;
            } else spawn = -2.26f;
            Vector3 spawnPosition = new Vector3(spawn, 5f, 0);
            Instantiate(enemyFalling2, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);

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
