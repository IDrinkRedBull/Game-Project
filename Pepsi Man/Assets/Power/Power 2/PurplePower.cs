using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurplePower : MonoBehaviour
{
    Inventory inventory;
    public GameObject icon;
    public Text text;
    bool touch;
    public Animator animator;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Pepsi").GetComponent<Inventory>();
        text.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (touch == true && Input.GetKeyDown(KeyCode.E))
        {
            pickup();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pepsi")
        {
            touch = true;
            text.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pepsi")
        {
            touch = false;
            text.gameObject.SetActive(false);
        }
    }
    private void pickup()
    {
        text.gameObject.SetActive(false);
        //Tar up saker och spara i inventory
        if (inventory.empty == true)
        {
            inventory.empty = false;
            Instantiate(icon, inventory.slot.transform);
            inventory.pickup[1] = true;
            animator.SetBool("pickup", true);
            Destroy(gameObject, 0.20f);
            //DestroyIt();
        }
    }

    IEnumerator DestroyIt()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

}