using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject welcometext;
    public GameObject exitbutton;
    public GameObject contonbutton;
    public void TriggerGameObject()
    {
        Destroy(exitbutton);
        Destroy(welcometext);
        Destroy(contonbutton);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
