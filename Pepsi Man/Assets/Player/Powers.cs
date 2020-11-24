using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    Inventory inventory;
    public Shooting shooting;
    public LongShoot longShoot;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
        shooting.enabled = false;
        longShoot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.PowerSlot[0] == true)
        {
            shooting.enabled = true;
        }
        else
        {
            shooting.enabled = false;
        }

        if (inventory.PowerSlot[1] == true)
        {
            longShoot.enabled = true;
        }
        else
        {
            longShoot.enabled = false;
        }
    }
}
