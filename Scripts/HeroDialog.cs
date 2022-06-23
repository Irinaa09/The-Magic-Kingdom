using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroDialog : MonoBehaviour
{
    public GameObject panelheroDialog;
    public GameObject paneldeadDialog;
    public GameObject room;
    public GameObject littlehero;
    public Text Herodialog;
    public Text Dead;
    public string[] message;
    public bool dialogStart = false;

    void Start()
    {
        message[0] = "Go little rockstar...";    
        panelheroDialog.SetActive(false);
        paneldeadDialog.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelheroDialog.SetActive(true);
            Herodialog.text = message[0];
            dialogStart = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panelheroDialog.SetActive(false);
        dialogStart = false;
    }


    private void Update()
    {
        if (dialogStart == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Herodialog.text = message[1];
            }
            
        }
    }
    public void TriggerGameObject()
    {
        Destroy(panelheroDialog);
        paneldeadDialog.SetActive(true);
        Destroy(room);
        Destroy(littlehero);

    }

}