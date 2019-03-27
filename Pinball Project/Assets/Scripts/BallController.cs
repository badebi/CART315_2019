using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Camera thirdPersonCamera;
    public float speed = 10;
    private Rigidbody rb;
    private bool groundContact = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space) && groundContact)
        {
            rb.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
            groundContact = false;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PinBall")
        {
            groundContact = true;
        }
    }
}
