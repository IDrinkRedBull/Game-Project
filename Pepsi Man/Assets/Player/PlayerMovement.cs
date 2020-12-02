using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public float JumpPower;
    public PlayerJump jumps;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Hoppa
        if(Input.GetKeyDown(KeyCode.Space) && jumps.jump)
        {
            rb.AddForce(Vector2.up * 800 * JumpPower);
            jumps.jump = false;
        }

        // Gå höger och vänster
        float walk = Input.GetAxis("Horizontal");
        transform.position += new Vector3(walk * Speed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180);
            animator.SetBool("Walking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0);
            animator.Play("PepsiWalk");
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }
}
