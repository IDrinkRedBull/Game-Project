using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    CameraFollow cameraPosition;
    public GameObject camera;
    public Animator boss;
    public bool animate = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = camera.GetComponent<CameraFollow>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pepsi")
        {
            cameraPosition.playerMode = false;
            boss.enabled = true;
        }
    }
}
