using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Camera mainCamera;
    public Camera thirdPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            mainCamera.enabled = !mainCamera.enabled;
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
        }
    }
}
