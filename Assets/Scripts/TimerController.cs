
using System;
using UnityEngine;
using UnityEngine.UI;
public class TimerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timer;
    public static float currentTime = 0f;
    private float roundedTime = 0f;
    void Start()
    {
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        roundedTime = (float)Math.Floor(Convert.ToDouble(currentTime));
        timer.text = "Time: " + roundedTime.ToString() + "s"; 
    }
}
