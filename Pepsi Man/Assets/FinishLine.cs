using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject Finish;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("Pepsi"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
