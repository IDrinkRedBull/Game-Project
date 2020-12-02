using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeTrapTrigger : MonoBehaviour
{
    CokeExplosion explosion;
    public GameObject trap;
    public void Start()
    {
        explosion = GameObject.FindGameObjectWithTag("TrapTrigger").GetComponent<CokeExplosion>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mentos")
        {
            Debug.Log("touchedss");
            explosion.trigger = true;
        }
    }
}
