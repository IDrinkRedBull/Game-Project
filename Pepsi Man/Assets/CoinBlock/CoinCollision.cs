using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public GameObject Coin;
    public Score score;
    public float points = 100;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("Pepsi"))
        {
            Destroy(Coin);
            score.points += points;
        }
    }

}
