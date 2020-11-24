using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPlatform : MonoBehaviour
{
    public float speed;
    public bool moveRight = true;
    public Transform groundDetection;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if (groundCheck.collider == false && moveRight == true)
        {
            transform.eulerAngles = new Vector3(0, 180);
            moveRight = false;
        }
        else if (groundCheck.collider == false && moveRight == false)
        {
            transform.eulerAngles = new Vector3(0, 0);
            moveRight = true;
        }
    }
}
