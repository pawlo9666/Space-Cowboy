using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScoreInfo : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        int currentscore = PlayerPrefs.GetInt("Score");
        score.text = "Score: " + currentscore;
        
    }

}
