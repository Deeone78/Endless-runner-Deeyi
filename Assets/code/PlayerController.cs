using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float movementValueX = 2.0f;
    public float jumpHeight = 25f;
    public Text scoreText;
    public GameObject groundChecker;

    public LayerMask whatIsGround;
    public bool doubleJump = true;
    public float moveSpeed = 5f;
    float scoreTimer = 0f;

    public float sprintSpeed = 10f;
    int score = 0;
    bool isOnGround = false;
    
    private Animator anim;
    Rigidbody2D playerObject;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerObject = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        scoreTimer += Time.deltaTime;
        if (scoreTimer >=0.5f)
        {
            score++;
            scoreTimer = 0f;
        }
        scoreText.text = "Score: " + score.ToString();
        //anim.SetFloat("Speed", Mathf.Abs(movementValueX));
        anim.SetBool("IsOnGround", isOnGround);
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





        //float movementValueX = Input.GetAxis("Horizontal");
        //float movementValueY = Input.GetAxis("Vertical");

        playerObject.velocity = new Vector2(movementValueX * moveSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
            playerObject.AddForce(new Vector2(0.0f, 100.0f * jumpHeight));

        }
        else if (Input.GetKeyDown(KeyCode.Space) && doubleJump) 
        {
            playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
            Debug.Log('d') ;
            playerObject.AddForce(new Vector2(0.0f, 100.0f * jumpHeight));
            doubleJump = false;
        }
        
        if (isOnGround == true)
        {
            doubleJump = true;




        }


        /*if (transform.position.y <= -6)
        {
            Time.timeScale = 0.0f;
        }*/


      



    }
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "PickUp")
            {
                score += 10;
                Destroy(collision.gameObject);
            }



        }
}
