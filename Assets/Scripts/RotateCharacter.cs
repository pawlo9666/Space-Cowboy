using UnityEngine;

public class RotateCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject arrow;
    [SerializeField]
    private Transform arrowPlace;
    public static int bullets;
    public static int bulletsFired;
    public float speed = 5f;
    private float angle;

    private void Awake()
    {
        bullets= 5;
        bulletsFired = 5;
    }

    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        if(Input.GetMouseButtonDown(0))
        {
            
            if(bulletsFired>0)
            {
                bulletsFired--;
                ShotArrow();
            }
            
        }
    }

    private void ShotArrow()
    {
        GameObject shotArrow = Instantiate(arrow, arrowPlace.position, arrowPlace.rotation);
        shotArrow.GetComponent<Rigidbody2D>().velocity = arrowPlace.right * 10f;
        this.GetComponent<AudioSource>().Play();
    }
}
