using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_game : MonoBehaviour
{
    public Score_timer score_Timer;
    public Enemies_spawner enemies_Spawner;
    public Spaceship_movement spaceship_Movement;
    public GameObject Pause;
    public int scoreSave = 0;
   public void PlayGame()
    {
        PlayerPrefs.DeleteKey("ScoreSave");
        Score_timer.count = 0;
        SceneManager.LoadScene("Main");
    }

    public void QuitLevel()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void Resume()
    {
        Pause.SetActive(false);
        enemies_Spawner.isPaused = false;
        Debug.Log(enemies_Spawner.isPaused);
        spaceship_Movement.speed = 5.0f;
        enemies_Spawner.spawnInterval = 1.0f;
    }

}
