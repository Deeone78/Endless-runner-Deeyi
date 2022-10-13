using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{
    public GameObject deathScreen;

    public GameObject spawner;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameOver")
        {
            Destroy(collision.gameObject);
            Debug.Log("GAMEOVER");
            spawner.SetActive(false);
            deathScreen.SetActive(true);
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
