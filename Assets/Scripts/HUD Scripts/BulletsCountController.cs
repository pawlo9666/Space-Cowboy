using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCountController : MonoBehaviour
{


    Text bullets;
    // Start is called before the first frame update
    void Start()
    {
        bullets = GetComponent<Text>();
        bullets.text = "Bullets: " + RotateCharacter.bulletsFired;
    }

    // Update is called once per frame
    void Update()
    {
        bullets.text = "Bullets: " + RotateCharacter.bulletsFired;
    }
}
