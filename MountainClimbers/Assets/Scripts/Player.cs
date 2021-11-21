using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spr;
    private Animator anim;
    private Vector2 leftWall, rightWall;
    int jumpForce = 2;
    float playerPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        leftWall = new Vector2(-3.51f, -1.63f);
        rightWall = new Vector2(4.146f, -1.63f);
    }

    private void Update()
    {
        playerPos = transform.position.x;


        if (Input.GetKeyDown(KeyCode.Space) && playerPos >= 4f)
        {
            transform.DOJump(leftWall, jumpForce, 1, 0.2f);
            spr.flipX = true;

        }

        if (Input.GetKeyDown(KeyCode.Space) && playerPos <= -3f)
        {
            transform.DOJump(rightWall, jumpForce, 1, 0.2f);
            spr.flipX = false;
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
