using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public Text finish;
    public bool quest;
    void Start()
    {
        quest = false;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            finish.text = "WINNNN! NEXT LEVEL?";
            quest = true;
        }
    }
    void OnGUI()
    {
        if (quest)
        {
   //         finish.text = "Победа! Продолжить?";
            if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 5 + 30, 100, 60), "yes"))
            {
                SceneManager.LoadScene(3);
            }
            if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height / 5 + 30, 100, 60), "no"))
            {
                quest = false;
            }
        }

    }

}