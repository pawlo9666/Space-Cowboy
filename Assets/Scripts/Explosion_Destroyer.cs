using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Destroyer : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, 0.3f);
    }
}
