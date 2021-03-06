﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetController : MonoBehaviour
{
    public GameObject explosion;
    public GameObject bomb;
    private GameObject kid;

    public void resetLevels()
    {
        PlayerPrefs.SetInt("Score", ScoreScript.scoreValue);
        PlayerPrefs.SetFloat("Time", TimerController.currentTime);
        ScoreScript.scoreValue = 0;
        TimerController.currentTime = 0f;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            RotateCharacter.bullets--;
            ScoreScript.scoreValue++;
            Instantiate(explosion, transform.position, transform.rotation);

            if (RotateCharacter.bullets == 0 && ScoreScript.scoreValue % 3 != 0)
            {
                resetLevels();
                SceneManager.LoadScene("GameOverMenu");
            }
            else if (ScoreScript.scoreValue % 3 != 0)
            {
                Vector3 position = new Vector3(Random.Range(-2, 2), 7, 0);

                 kid = Instantiate(bomb, position, transform.rotation);
                 kid.transform.parent = this.transform.parent;
                 this.transform.parent.GetComponent<AudioSource>().Play();
            }
            else if (ScoreScript.scoreValue % 3 == 0)
            {
                int next = PlayerPrefs.GetInt("Level") + 1;
                PlayerPrefs.SetInt("Score", ScoreScript.scoreValue);
                PlayerPrefs.SetFloat("Time", TimerController.currentTime);
                PlayerPrefs.SetInt("Level", next);

                if (next == 6)
                {
                    SceneManager.LoadScene("TheEndMenu");
                }
                else
                {
                    SceneManager.LoadScene("NextLevelMenu");
                }

            }

            Destroy(this.gameObject);
            Destroy(collision.gameObject);

        }
    }
}
