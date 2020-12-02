using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 15;
            Debug.Log("Enemy health: " + health + "hp");
            animator.SetTrigger("Hit");
        }
        else if (collision.gameObject.tag == "7Bullet")
        {
            health -= 7;
            Debug.Log("Enemy health: " + health + "hp");
            animator.SetTrigger("Hit");
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
