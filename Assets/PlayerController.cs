using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight = 100f;
    
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

        if (Input.GetKey(KeyCode.LeftShift))
        {

            moveSpeed = 10.0f;
        } else
        {
            moveSpeed = 5.0f;

        }





        float movementValueX = Input.GetAxis("Horizontal");
        float movementValueY = Input.GetAxis("Vertical");
       // float movementValueX = 1.0f;
        playerObject.velocity = new Vector2(movementValueX * moveSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position,1.0f,whatIsGround);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true )
        {

            playerObject.AddForce(new Vector2 (0.0f, 100.0f*jumpHeight));
        
        }
        if (transform.position.y <= -6)
        {
            Time.timeScale = 0.0f;
        }
        
        




    }
}
