using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    int multiplier = 1;

    public TextMesh multipier;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
    }

    public void AddScore(int points)
    {
        score = score + points * multiplier;
    }

    public void AddMultiplier(int multiplierPoints)
    {
        multiplier += multiplierPoints;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
    }
}
