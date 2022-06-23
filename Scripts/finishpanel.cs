using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishpanel : MonoBehaviour
{
    public GameObject panelfinish;
    public Text open;



    void Start()
    {
        panelfinish.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelfinish.SetActive(true);
            Destroy(open);
        }
    }

}