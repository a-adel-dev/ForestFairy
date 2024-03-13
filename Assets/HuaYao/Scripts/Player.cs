using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 5.0f;
    public float JumpForce = 2.0f;
    bool grounded;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalMovement, 0 , verticalMovement) * movementSpeed;


        bool jumpButton = Input.GetButton("Jump");

        if (jumpButton && grounded)
        {
            Debug.Log("jump button pressed");
            rb.AddForce((Vector3.up * JumpForce),ForceMode.Impulse);
        }
    }
}
