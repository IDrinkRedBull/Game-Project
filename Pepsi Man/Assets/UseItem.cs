using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UseItem : MonoBehaviour
{
    public GameObject vending;
    Inventory inventory;
    public DestroyItem destroyitem;
    public bool keep;
    public Text getText;
    public Animator animator;
    private void Start()
    {
        inventory = vending.GetComponent<Inventory>();
        destroyitem = vending.GetComponent<DestroyItem>();
        destroyitem = GameObject.FindObjectOfType(typeof(DestroyItem)) as DestroyItem;
        getText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (keep && Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("work");
            UseItems();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pepsi")
        {
            keep = true;
            getText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pepsi")
        {
            keep = false;
            getText.gameObject.SetActive(false);
        }
        
    }

    private void UseItems()
    {
        if (inventory.pickup[0] == true)
        {
            animator.SetTrigger("Exchanged");
            Debug.Log("Powered1");
            inventory.pickup[0] = false;
            inventory.empty = false;
            for (int i = 0; i < inventory.PowerSlot.Length; i++)
            {
                inventory.PowerSlot[i] = false;
                inventory.PowerSlot[0] = true;

            }
            destroyitem.DestroyIcon();
        }

        else if (inventory.pickup[1] == true)
        {
            Debug.Log("Powered2");
            inventory.pickup[1] = false;
            inventory.empty = false;
            for (int i = 0; i < inventory.PowerSlot.Length; i++)
            {
                inventory.PowerSlot[i] = false;
                inventory.PowerSlot[1] = true;
            }
            destroyitem.DestroyIcon();
        }
    }
}

