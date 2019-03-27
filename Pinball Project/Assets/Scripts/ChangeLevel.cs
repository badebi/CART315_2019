using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{

    public Camera cam;
    public Transform nextCamera;
    public GameObject ball;
    public GameObject PrevLevel;
    public GameObject NextLevel;
    public GameObject nextGameOverLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            PrevLevel.SetActive(false);
            cam.transform.position = nextCamera.position ;
            foreach (Transform child in PrevLevel.transform)
            {
                child.gameObject.SetActive(false);
            }

            NextLevel.SetActive(true);
            nextGameOverLimit.SetActive(true);

            //PrevLevel.GetComponent<Renderer>().enabled = false;
            //NextLevel.GetComponent<Renderer>().enabled = true;
        }
    }
}
