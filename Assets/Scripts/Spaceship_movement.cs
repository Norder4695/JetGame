using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spaceship_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;

    public float minX = -2.54f;
    public float maxX = 2.55f;
    public Enemies_spawner enemies_Spawner;
    public Score_timer score_Timer;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        if (enemies_Spawner.isPlayerAlive == false)
        {
            speed = 0f;
        }
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector3 movement = new Vector3(moveHorizontal, 0, 0);

            transform.position += movement * speed * Time.deltaTime;

            float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);

            transform.position = new Vector3(clampedX, -2.97f, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector3.up * bulletSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            speed = 0f;
        }
       

    }
}
