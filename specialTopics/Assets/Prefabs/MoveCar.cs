using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public float torqueSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(v, 0.0f, 0.0f);
        Vector3 torque = new Vector3(0.0f, h, 0.0f);
        //rb.AddForce(movement * speed);
        rb.AddTorque(torque * torqueSpeed);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(-transform.right * speed);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            rb.AddForce(-transform.forward * speed);
        }


    }
}
