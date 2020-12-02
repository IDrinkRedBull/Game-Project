using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform bossRoom;
    public bool playerMode = true;
    public Transform Player;
    public Vector3 offset;
    void Update()
    {
        if (playerMode)
        {
            transform.position = Player.position + offset;
        }
        else if (!playerMode)
        {
            transform.position = bossRoom.position + offset;
        }
        
    }
}
