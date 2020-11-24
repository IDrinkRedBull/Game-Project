using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(poof(0.5f));
    }

    IEnumerator poof(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(gameObject);
    }
}
