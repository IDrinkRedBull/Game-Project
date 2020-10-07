using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int health = 100;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 20;
            Debug.Log("Enemy health: " + health + "hp");
        }
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
