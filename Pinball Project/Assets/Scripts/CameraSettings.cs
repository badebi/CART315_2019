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

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (theScore.ballControllAvailable)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                theScore.SetNewTreshold();
                StartCoroutine(BallControllMode(ballControllModeDuration));
            }
        }
        else
        {
            StopCoroutine(BallControllMode(ballControllModeDuration));
        }
        

    }

    public IEnumerator BallControllMode(float _duration)
    {
        float i = 0.0f;

        while (i < ballControllModeDuration)
        {
            i += Time.deltaTime;
            countDown.text = (ballControllModeDuration - i).ToString("00.00");
            mainCamera.enabled = false;
            thirdPersonCamera.enabled = true;
            GetComponent<BallController>().enabled = true;
            yield return null;
        }
        if (i >= ballControllModeDuration || gameOver.gameOver == true)
        {
            countDown.text = "";
            theScore.ballControllAvailable = false;
            mainCamera.enabled = true;
            thirdPersonCamera.enabled = false;
            GetComponent<BallController>().enabled = false;
            gameOver.gameOver = false;
            yield return null;
        }

    }

}
