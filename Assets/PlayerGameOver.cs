using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameOver")
        {
            Destroy(collision.gameObject);
            print("GAMEOVER");
        }



    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
