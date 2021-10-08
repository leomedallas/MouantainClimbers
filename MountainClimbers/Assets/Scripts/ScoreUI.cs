using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Destroyer destroyer;
    public Text text;

    private void FixedUpdate()
    {
        text.text = destroyer.score.ToString();
    }
}
