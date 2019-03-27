using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{

    public GameObject ball;
    public GameObject PrevLevel;
    public GameObject NextLevel;

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
            foreach (Transform child in PrevLevel.transform)
            {
                child.gameObject.SetActive(false);
            }
            //NextLevel.SetActive(true);
            //PrevLevel.GetComponent<Renderer>().enabled = false;
            //NextLevel.GetComponent<Renderer>().enabled = true;
        }
    }
}
