using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    /*float speed = 200f;
    float movement = 0f;*/
    public GameObject core;
    public int pos = 0;
    public GameObject[] order;
    
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = pos - 1;
            Debug.Log(pos);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            pos = pos + 1;
            Debug.Log(pos);
        }

    }

    private void FixedUpdate()
    {
        this.transform.position = order[pos].transform.position;
        Debug.Log(pos);

        if (pos == 0)
        {
            pos = 6;
        }
        else if (pos == 7)
        {
            pos = 1;
        }
        // Move around "core", move at position (0, 0, -1), move in horizontal(movement) with speed(speed = 200f)
        //transform.RotateAround(core.transform.position, Vector3.back, movement * Time.deltaTime * speed);
    }
}
