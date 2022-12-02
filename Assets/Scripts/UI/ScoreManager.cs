using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI score;

    [HideInInspector]
    public int currentScore;


    void Awake()
    {
        currentScore = 0;
    }

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;

        score.text = "Score: "  + currentScore.ToString();   
    }
}
