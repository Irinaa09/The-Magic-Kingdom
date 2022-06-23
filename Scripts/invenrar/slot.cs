using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private Inventory inventory;
    public int i;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
    }
 
    

    // Update is called once per frame
    private void Update()
    {
        if(transform.childCount <0)
        {
            inventory.isFull[i] = false;
        }
        
    }
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
