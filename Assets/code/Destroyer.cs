using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "CleanUp")
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "Pickup")
        {
            Destroy(collision.gameObject);

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
