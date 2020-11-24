using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody2D rb;
    public int health = 100;
    public Animator animator;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Mentos")
        {
            health -= 50;
            Debug.Log(health + "Health");
            animator.SetTrigger("Hit");
        }
        else if (collision.gameObject.tag == "Trap")
        {
            health -= 100;
            Debug.Log(health + "Health");
            animator.SetTrigger("Hit");
        }
        if(health <= 0)
        {
            Debug.Log("Dead!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            health -= 50;
            Debug.Log(health + "Health");
            animator.SetTrigger("Hit trigger");
        }
        if (health <= 0)
        {
            Debug.Log("Dead!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
