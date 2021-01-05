using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevels : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));    
    }
    public void ToMenu()
    {
        ScoreScript.scoreValue = 0;
        TimerController.currentTime = 0f;
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        ScoreScript.scoreValue = 0;
        TimerController.currentTime = 0f;
        SceneManager.LoadScene("Firstlevel");
    }


}
