using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_game : MonoBehaviour
{
    public Score_timer score_Timer;
    public Enemies_spawner enemies_Spawner;
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
    }

}
