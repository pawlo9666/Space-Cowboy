using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowController : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 lastVelocity;

    public void resetLevels()
    {
        PlayerPrefs.SetInt("Score", ScoreScript.scoreValue);
        PlayerPrefs.SetFloat("Time", TimerController.currentTime);
        ScoreScript.scoreValue = 0;
        TimerController.currentTime = 0f;
    }
    // Start is called before the first frame update

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;   
    }

    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles") || collision.gameObject.CompareTag("Arrow"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);       
            rb.velocity = direction * Mathf.Max(speed, 0f);
            collision.gameObject.GetComponent<AudioSource>().Play();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation , q , Time.deltaTime * 50f );        
        }

        if(collision.gameObject.CompareTag("Destroy"))
        {
            RotateCharacter.bullets--;
            Destroy(this.gameObject);

            if(RotateCharacter.bullets == 0)
            {
                resetLevels();
                SceneManager.LoadScene("GameOverMenu");
            }
        }


        
    }
}
