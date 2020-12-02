using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mentos_Gun : MonoBehaviour
{
    public GameObject mentos;
    public Transform point;
    public float sec = 3;
    bool check = true;
    void Start()
    {
        StartCoroutine(shootTimer(sec));
    }


    IEnumerator shootTimer(float s)
    {
        while (check == true)
        {
        yield return new WaitForSeconds(s);
            Instantiate(mentos, point.position, point.rotation);
        }
        
    }

}
