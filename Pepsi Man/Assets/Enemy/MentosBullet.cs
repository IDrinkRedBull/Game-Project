using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentosBullet : MonoBehaviour
{
    public float velocity = 10;
    public Rigidbody2D rb;
    public GameObject mentos;
    float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != 8)
        {
            Destroy(gameObject);
        }
    }

}
