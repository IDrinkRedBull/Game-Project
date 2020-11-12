using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    public void Start()
    {
        Invoke("Update", 1f);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }


}
