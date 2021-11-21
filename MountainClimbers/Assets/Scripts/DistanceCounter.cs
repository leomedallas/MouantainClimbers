using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceCounter : MonoBehaviour
{
    float distance;
    int distanceInt;
    public TMP_Text txt;

    private void Update()
    {
        distance += Time.deltaTime;
        distanceInt = (int)distance;
        txt.text = distanceInt.ToString() + "m";
    }
}
