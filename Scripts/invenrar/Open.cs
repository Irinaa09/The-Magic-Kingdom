using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour
{
    public GameObject barer;
    public GameObject barerr;
    public GameObject vorota;
    public GameObject bare;

    public Text Opentext;
    Rigidbody2D rb = new Rigidbody2D();
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("key"))
        {
            Opentext.text = " Àﬁ◊ ” “≈¡ﬂ ";
    
            Destroy(vorota);
            Destroy(bare);
            Destroy(barer);
            Destroy(barerr);

        }
      
    }
    public void TriggerGameObject()
    {
        Destroy(barer);

    }



    void Update()
    {
        
    }
}
