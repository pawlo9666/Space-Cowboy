using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MenuTimeInfo : MonoBehaviour
{
    Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
        float currentTime = PlayerPrefs.GetFloat("Time");
        timer.text = "Time: " + currentTime.ToString("F2");
    }

}
