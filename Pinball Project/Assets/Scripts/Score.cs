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

  

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
            this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
            multiplierText.text = "x" + multiplier.ToString();
        
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
           ballControllAvailable = true;
        }
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
        //ballControllAvailable = false;
    }
}
