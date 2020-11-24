using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mentos_Gun : MonoBehaviour
{
    public GameObject mentos;
    public Transform point;
    bool check = true;
    void Start()
    {
        StartCoroutine(shootTimer(3));
    }


    IEnumerator shootTimer(float sec)
    {
        while (check == true)
        {
        yield return new WaitForSeconds(sec);
            Instantiate(mentos, point.position, point.rotation);
        }
        
    }

}
