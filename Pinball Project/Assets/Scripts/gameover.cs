using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    private Vector3 initialposition;
    public GameObject ball;
    public Score theScore;

    // Start is called before the first frame update
    void Start()
    {
        initialposition = ball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            Debug.Log("Game Over");
            ball.transform.position = initialposition;
            theScore.ResetScore();
            theScore.ResetMultiplier();
            theScore.ballControllAvailable = false;
        }
    }
}
