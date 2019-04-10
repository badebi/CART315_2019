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

        //CheckJump();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void CheckJump()
    {
        if (Input.GetButton("Jump") && groundContact)
        {
            rb.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
            groundContact = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PinBall" || collision.gameObject.name == "PinBall(1)" || collision.gameObject.name == "Table")
        {
            groundContact = true;
            Debug.Log("can jump");
        }
    }
}
