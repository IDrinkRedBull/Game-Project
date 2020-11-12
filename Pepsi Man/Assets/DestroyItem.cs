using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    Inventory inventory;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Pepsi").GetComponent<Inventory>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DestroyIcon();
        }
    }
    public void DestroyIcon()
    {
        //knapp som förstör saker man har i inventory
        foreach(Transform child in transform)
        {
            Debug.Log("POW1");
            GameObject.Destroy(child.gameObject);
            inventory.empty = true;
            for (int i = 0; i < inventory.pickup.Length; i++)
            {
                Debug.Log("POW2");
                inventory.pickup[i] = false;
            }
        }
    }
}
