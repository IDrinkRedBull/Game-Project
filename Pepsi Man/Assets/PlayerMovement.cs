﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public float JumpPower;
    public PlayerJump jumps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && jumps.jump == true)
        {
            rb.AddForce(Vector2.up * 800 * JumpPower);
            jumps.jump = false;
        }


        float walk = Input.GetAxis("Horizontal");
        transform.position += new Vector3(walk * Speed * Time.deltaTime, 0f);
    }
}
