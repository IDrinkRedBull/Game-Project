using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Inventory tar upp och spara saker
    public bool empty;
    public bool[] pickup;
    public bool[] PowerSlot;
    public GameObject slot;
    public Text Rshoot;
    public Text power;
    private void Start()
    {
        Rshoot.enabled = false;
    }
    private void FixedUpdate()
    {
        if (PowerSlot[0] == true)
        {
            power.text = "Pepsi Max";
            disableText();
        }
        if (PowerSlot[1] == true)
        {
            power.text = "7up";
            disableText();
        }
    }

    void DisableText()
    {
        Rshoot.enabled = false;
    }
    
    void disableText()
    {
        Rshoot.enabled = true;
        Invoke("DisableText", 5f);
    }
    
}
