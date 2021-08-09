using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementPlayer : MonoBehaviour
{

    public float speed;
    public float jumpforce;

    public Animator anim;
    
    bool isJumping;
    Rigidbody2D playerRidgidbody;


	// Use this for initialization
	void Start ()
    {
        playerRidgidbody = GetComponent<Rigidbody2D>();
	}
	



	// Update is called once per frame
	void FixedUpdate ()
    {
        float move = Input.GetAxis("Horizontal");
        playerRidgidbody.velocity = new Vector2(speed * move, playerRidgidbody.velocity.y);

        Jump();
	}


    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isJumping == true || (Input.GetKey(KeyCode.W) && isJumping == true))
        {
            isJumping = false;
            StartCoroutine(SquashJump());
            
            playerRidgidbody.AddForce(new Vector2(playerRidgidbody.velocity.x, jumpforce));
        }
        
    }

    IEnumerator SquashJump()
    {
        anim.SetBool("Jump", true);
        anim.Play("JumpSquash", 0,0.25f );
        yield return new WaitForSeconds(1f);
        anim.SetBool("Jump", false);
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Platform"))
        {
            isJumping = true;
            playerRidgidbody.velocity = Vector2.zero;          
        }
        else if (other.gameObject.CompareTag("Converter"))
        {
            isJumping = true;
            playerRidgidbody.velocity = Vector2.zero;            
        }
        else if (other.gameObject.CompareTag("Red"))
        {
            isJumping = true;
            playerRidgidbody.velocity = Vector2.zero;            
        }
        else if (other.gameObject.CompareTag("Blue"))
        {
            isJumping = true;
            playerRidgidbody.velocity = Vector2.zero;            
        }
        else if (other.gameObject.CompareTag("Green"))
        {
            isJumping = true;
            playerRidgidbody.velocity = Vector2.zero;            
        }
        else
        {
            isJumping = false;
        }
    }



}
