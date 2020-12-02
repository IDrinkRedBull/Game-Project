using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    BossHealth health;
    CameraFollow camera;

    void Start()
    {
        health = GameObject.Find("Trocadero").GetComponent<BossHealth>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health <= 0)
        {
            gameObject.SetActive(false);
            camera.playerMode = true;
        }
    }
}
