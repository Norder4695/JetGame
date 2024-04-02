using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemies_spawner enemies_Spawner;
    public TMP_Text scoreText;
    public static int count = 0;
    public float speed = 0.3f;
    private float timer = 0.0f;
    public Play_game play_Game;
    void Start()
    {
        scoreText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!enemies_Spawner.isPaused)
        {
            timer += Time.deltaTime;
            if (timer > speed)
            {
                timer -= speed;
                if (enemies_Spawner.isPlayerAlive)
                {
                    count++;
                    scoreText.text = count.ToString();

                    if (count > 30 && count < 50)
                    {
                        speed = 0.25f;
                    }
                    else if (count > 50 && count < 100)
                    {
                        speed = 0.1f;
                    }
                    else if (count > 100)
                    {
                        speed = 0.05f;
                    }
                }
            }
        }
        
    }
}
