using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private Transform player; 
    public GameObject item;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 2, player.position.y - 1);
        Instantiate(item, playerPos, Quaternion.identity);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
