using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int modeSwitchTreshold = 5;
    int score = 0;
    int multiplier = 1;
    public bool ballControllAvailable = false;
    public TMPro.TextMeshPro multiplierText;
    public TMPro.TextMeshPro superPower;
    public TMPro.TextMeshPro treshold;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
        multiplierText.text = "x" + multiplier.ToString();
        treshold.text = "x" + modeSwitchTreshold.ToString();
    }

    public void AddScore(int points)
    {
        score = score + points * multiplier;
    }

    public void AddMultiplier(int multiplierPoints)
    {
        multiplier += multiplierPoints;

        if(multiplier >= modeSwitchTreshold)
        {
            superPower.text = "Press UP ARROW";
            ballControllAvailable = true;
        } else
        {
            superPower.text = "";
        }
    }

    public void ResetScore()
    {
        score = 0;
        modeSwitchTreshold = 5;
        superPower.text = "";
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
        ballControllAvailable = false;
        superPower.text = "";
    }

    public void HandleMultiplier()
    {
        multiplier = Mathf.FloorToInt(multiplier / 2.0f);
        if (multiplier > modeSwitchTreshold)
        {
            multiplier = Mathf.FloorToInt(multiplier / 2.0f);
        }
    }

    public void SetNewTreshold()
    {
        modeSwitchTreshold = multiplier;
    }
}
