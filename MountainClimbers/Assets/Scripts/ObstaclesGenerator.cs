using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    public GameObject[] spikes;
    int instanceCount = 1;

    private void Start()
    {
        InvokeRepeating("CreateSpikes", 1.0f, 2.0f);
    }

    public void CreateSpikes()
    {
        for (int i = 0; i < instanceCount; i++)
        {
            int actualSpikes = Random.Range(0, spikes.Length);

            if(actualSpikes == 0)
            {
                GameObject left = Instantiate(spikes[0]) as GameObject;
                left.transform.position = new Vector2(-2.51f, 5.02f);
            }

            if(actualSpikes == 1)
            {
                GameObject right = Instantiate(spikes[1]) as GameObject;
                right.transform.position = new Vector2(3.15f, 5.02f);
            }
        }
    }
}
