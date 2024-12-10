using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerScore : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
