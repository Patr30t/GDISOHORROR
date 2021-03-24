using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itempickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemIcon;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isOccupied[i] == false) {
                    //ITEM ADDED!!
                    inventory.isOccupied[i] = true;
                    Instantiate(itemIcon, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }

        }
        
    }
 
}
