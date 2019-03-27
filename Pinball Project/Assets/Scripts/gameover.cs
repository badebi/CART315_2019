using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public Camera cam;
    private Vector3 initialposition;
    private Vector3 initialCamPosition;
    public GameObject ball;
    public Score theScore;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        initialposition = ball.transform.position;
        initialCamPosition = cam.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            gameOver = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene("Pinball Project");
            //ball.transform.position = initialposition;
            //theScore.ResetScore();
            //theScore.ResetMultiplier();
            //theScore.ballControllAvailable = false;
            //cam.transform.position = initialCamPosition;
        }
    }
}
