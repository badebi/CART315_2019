using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Camera mainCamera;
    public Camera thirdPersonCamera;
    public Score theScore;
    public float ballControllModeDuration = 5.0f;
    public TMPro.TextMeshPro countDown;
    public gameover gameOver;
    public GameObject jumpText;
    public TMPro.TextMeshPro ballControllTime;
    private float addedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        handleBallControllDuration();
        if (theScore.ballControllAvailable)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                ballControllModeDuration += addedTime;
                theScore.SetNewTreshold();
                StartCoroutine(BallControllMode(ballControllModeDuration));
            }
        }
        else
        {
            StopCoroutine(BallControllMode(ballControllModeDuration));
        }
        

    }

    private void handleBallControllDuration()
    {
        if (theScore.multiplier > theScore.modeSwitchTreshold)
        {
            addedTime = (theScore.multiplier - theScore.modeSwitchTreshold) / 4.0f;
            
            ballControllTime.text = "5.0s + " + addedTime.ToString("00.00") + "s";
        }
        else
        {
            //ballControllModeDuration = 5.0f;
            ballControllTime.text = "5.0s";
        }
    }

    public IEnumerator BallControllMode(float _duration)
    {
        float i = 0.0f;

        while (i < ballControllModeDuration)
        {
            i += Time.deltaTime;
            countDown.text = (ballControllModeDuration - i).ToString("00.00");
            if (theScore.score >= theScore.levelUnlockScore) {
                jumpText.SetActive(true);
            }
            
            mainCamera.enabled = false;
            thirdPersonCamera.enabled = true;
            GetComponent<BallController>().enabled = true;
            yield return null;
        }
        if (i >= ballControllModeDuration || gameOver.gameOver == true)
        {
            theScore.HandleMultiplier();
            countDown.text = "";
            theScore.ballControllAvailable = false;
            jumpText.SetActive(false);
            mainCamera.enabled = true;
            thirdPersonCamera.enabled = false;
            GetComponent<BallController>().enabled = false;
            gameOver.gameOver = false;
            yield return null;
        }

    }

}
