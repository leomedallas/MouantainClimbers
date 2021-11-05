using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    public GameObject leftObstacle;
    public GameObject rightObstacle;

    private void Start()
    {
        StartCoroutine("LeftObstacleSpawn");
        StartCoroutine("RightObstacleSpawn");
    }

    private void SpawnLeftObstacle()
    {
        GameObject left = Instantiate(leftObstacle) as GameObject;
        left.transform.position = new Vector2(-2.51f, 5.02f);

    }

    private void SpawnRightObstacle()
    {
        GameObject right = Instantiate(rightObstacle) as GameObject;
        right.transform.position = new Vector2(3.15f, 5.02f);
    }

    IEnumerator LeftObstacleSpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(2, 4));
            SpawnLeftObstacle();
        }  
    }

    IEnumerator RightObstacleSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 8));
            SpawnRightObstacle();
        }
    }
}
