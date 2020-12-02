using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentosBullet : MonoBehaviour
{
    public float velocity = 10;
    public Rigidbody2D rb;
    public GameObject mentos;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
        }
    }

}
