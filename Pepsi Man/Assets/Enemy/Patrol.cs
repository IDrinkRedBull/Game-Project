using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public bool movingRight = true;
    public Transform groundDetection;
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundDetection.position, Vector2.down, 3f);
        if (groundCheck.collider.gameObject.tag == "PatrolBarrier" && movingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 180);
            movingRight = false;
        }
        else if (groundCheck.collider.gameObject.tag == "PatrolBarrier" && movingRight == false)
        {
            transform.eulerAngles = new Vector3(0, 0);
            movingRight = true;
        }
    }
}
