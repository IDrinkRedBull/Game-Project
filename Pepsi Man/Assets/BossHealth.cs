using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealth : MonoBehaviour
{
    public int health = 500;
    public Animator animator;
    public Text healthText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            healthText.text = health.ToString();
            health -= 15;
            Debug.Log("Enemy health: " + health + "hp");
        }
        else if (collision.gameObject.tag == "7Bullet")
        {
            health -= 7;
            Debug.Log("Enemy health: " + health + "hp");
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            healthText.text = 10.ToString();
        }
    }
}
