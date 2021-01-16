using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    private float scrollSpeed = 10f;

    float horizontalInput;
    float verticalInput;
    float wheelInput;

    public float speedH = 5.0f;
    public float speedV = 5.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;



    void Update()
    {
        Vector3 rotation = transform.eulerAngles;



        float ScrollWheelChange = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.transform.position += Camera.main.transform.forward * ScrollWheelChange * 3;
    }

    void FixedUpdate()
    {


        if (Input.GetMouseButton(2))
        {

            if (Input.GetAxis("Mouse X") > 0)
            {
                Camera.main.transform.position += moveSpeed / 2 * -Camera.main.transform.right;
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                Camera.main.transform.position += moveSpeed / 2 * Camera.main.transform.right;
            }

            if (Input.GetAxis("Mouse Y") > 0)
            {
                Camera.main.transform.position += moveSpeed / 2 * -Camera.main.transform.up;
            }
            if (Input.GetAxis("Mouse Y") < 0)
            {
                Camera.main.transform.position += moveSpeed / 2 * Camera.main.transform.up;
            }
        }

        if (Input.GetMouseButtonDown(2))
        {
            transform.position += scrollSpeed * new Vector3(0, Input.GetAxis("Mouse X"), 0);
        }



        if (Input.GetMouseButton(1))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
