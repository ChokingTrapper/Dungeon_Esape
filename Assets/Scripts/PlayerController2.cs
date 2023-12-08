using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{   
    private float horizontal;
    private float speed=8f;
    private float JumpingPower=18f;
    private bool verticaldown,verticalup,isFacingRight=true;


    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Transform  groundcheck;
    [SerializeField] LayerMask groundlayer;
    [SerializeField] Transform SpawnPoint;
    [SerializeField] Transform Self;
    [SerializeField] Animator animator;

    
    // Update is called once per frame
    private void Start() {

        Self.position = SpawnPoint.position;

        
    }
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        verticaldown = Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W);
        verticalup = Input.GetButtonUp("Jump") || Input.GetKeyUp(KeyCode.W);

        Flip();
        if(!isGrounded())
        {
            animator.SetBool("IsFall",true);
            //animator.SetBool("IsRunning",false);

        }
        else
        {
            animator.SetBool("IsFall",false);
        }


        if(verticaldown && isGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,JumpingPower);
        }
        if(verticalup && rb2d.velocity.y>0)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,rb2d.velocity.y*0.3f);
        }
    }
    private void FixedUpdate() 
    {
        rb2d.velocity = new Vector2(horizontal*speed,rb2d.velocity.y);
        if(horizontal!=0f)
        {
        animator.SetBool("IsRunning",true);
        }
        else
        {
            animator.SetBool("IsRunning",false);
        }
        
    }

    private bool isGrounded()
    {
        RaycastHit2D hit;

        hit = Physics2D.Raycast(groundcheck.position,Vector2.down,0.2f,groundlayer);

        
        return hit;

    }

    public void ResetEverything()
    {
        Self.position = SpawnPoint.position;
    }

    private void Flip()
    {
        if(isFacingRight && horizontal<0f || !isFacingRight && horizontal>0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localscale = Self.localScale;
            localscale.x *=-1;
            Self.localScale = localscale;
        }

    }

}
