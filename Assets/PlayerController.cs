using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight = 2f;
    
    public GameObject groundChecker;

    public LayerMask whatIsGround;
    
    public float moveSpeed = 5f;

    public float sprintSpeed = 10f;

    bool isOnGround = false;
    
    Rigidbody2D playerObject;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.LeftShift))
        {

           moveSpeed=7.5f;


        }*/


        float movementValueX = Input.GetAxis("Horizontal");
        //float movementValueY = Input.GetAxis("Vertical");
        playerObject.velocity = new Vector2(movementValueX * moveSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position,1.0f,whatIsGround);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true )
        {

            playerObject.AddForce(new Vector2 (0.0f, 100.0f*jumpHeight));
        
        }

        





    }
}
