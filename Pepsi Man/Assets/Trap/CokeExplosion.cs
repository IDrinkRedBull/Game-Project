using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeExplosion : MonoBehaviour
{
    public Animator animator;
    public bool trigger;
    // Start is called before the first frame update
    public void FixedUpdate()
    {
        if (trigger == true)
        {
            play();
        }
    }

    // Update is called once per frame

    public void play()
    {
            animator.SetTrigger("Explosion");
            trigger = false;  
    }
}
