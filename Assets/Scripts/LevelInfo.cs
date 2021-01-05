using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelInfo : MonoBehaviour
{
    private static readonly string Level = "Level";
    private static int LevelIndex; 
    // Start is called before the first frame update
    void Awake()
    {
        LevelIndex= SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt(Level, LevelIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            ScoreScript.scoreValue = 0;
            TimerController.currentTime = 0f;
            PlayerPrefs.SetInt("Score", ScoreScript.scoreValue);
            PlayerPrefs.SetFloat("Time", TimerController.currentTime);
            SceneManager.LoadScene("Menu");
        }
    }

}
