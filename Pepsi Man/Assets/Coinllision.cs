using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinllision : MonoBehaviour
{
    public GameObject Coin;
    public Score score;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pepsi")
        {
            Debug.Log("bruh coin");
            Destroy(Coin);
            score.points += 100;
        }
    }
}
