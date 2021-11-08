using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spr;
    private Animator anim;
    int JumpForce = 8;
    float playerPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        playerPos = transform.position.x;


        if (Input.GetKeyDown(KeyCode.Space) && playerPos >= 4f)
        {
            //transform.Translate(Vector3.left * JumpForce);
            anim.SetBool("IsJump", true);
            anim.SetBool("StandRight", false);
            
        }
        else if(playerPos >= 4f)
        {
            //transform.position = new Vector2(4.15f, -1.63f);
            //spr.flipX = false;
            anim.SetBool("IsJumpRight", false);
            anim.SetBool("StandRight", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && playerPos <= -3f)
        {
            //transform.Translate(Vector3.right * JumpForce);
            anim.SetBool("IsJumpRight", true);
            anim.SetBool("StandLeft", false);
        }
        else if(playerPos <= -3f)
        {
            //transform.position = new Vector2(-3.5f, -1.63f);
            //spr.flipX = true;
            anim.SetBool("IsJump", false);
            anim.SetBool("StandLeft", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        } 
    }
}
