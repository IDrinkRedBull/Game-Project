using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private void Update()
    {
        float walk = Input.GetAxis("Horizontal");
        transform.position += new Vector3(walk * 5 * Time.deltaTime, 0);
    }
}
