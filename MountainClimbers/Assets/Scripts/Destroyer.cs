using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject player, platform;
    private GameObject myPlatform;
    public int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            myPlatform = (GameObject)Instantiate(platform, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (15f + Random.Range(1.5f, 3.0f))), Quaternion.identity);
            Destroy(collision.gameObject);
            score++;
        }
    }
}
