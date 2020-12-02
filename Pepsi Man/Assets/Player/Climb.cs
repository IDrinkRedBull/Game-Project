using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    public bool climb;
    public float climbSpeed;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        if (climb == true && Input.GetKey(KeyCode.W))
        {
            Debug.Log("Laddered");
            rb.velocity = new Vector2(0, 1 * climbSpeed);
            //rb.velocity = new Vector2(0, 10);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            climb = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            climb = false;
        }
    }
}
