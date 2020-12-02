using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFlip : MonoBehaviour
{
    public Transform player;
    bool flip = false;

    public void FollowPlayer()
    {
        if (transform.position.x > player.position.x && flip)
        {
            transform.eulerAngles = new Vector3(0, 0);
            flip = false;
        }
        else if (transform.position.x < player.position.x && !flip)
        {
            transform.eulerAngles = new Vector3(0, 180);
            flip = true;
        }
    }
}
