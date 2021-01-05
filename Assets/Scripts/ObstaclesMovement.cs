using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float obstaclespeed;
    public float rotateSpeed;

    void Update()
    {

        transform.Rotate(0, 0, rotateSpeed);
        transform.position += Vector3.right * obstaclespeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Turn"))
        {
            obstaclespeed *= -1;
        }
    }
}
