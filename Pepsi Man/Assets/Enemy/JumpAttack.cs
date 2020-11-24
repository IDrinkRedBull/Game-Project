using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : MonoBehaviour
{
    bool alive = true;
    public Rigidbody2D rb;
    public float jumpPower;
    public GameObject energi;
    public GameObject explosion;
    public Transform explodePoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(smash(3));
    }

    IEnumerator smash(float delay)
    {
        while (alive = true)
        {
            yield return new WaitForSeconds(delay);
            rb.AddForce(Vector2.up * jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Instantiate(explosion, explodePoint.position, explodePoint.rotation);
        }
    }
}
