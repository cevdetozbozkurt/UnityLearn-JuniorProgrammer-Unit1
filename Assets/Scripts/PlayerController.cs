using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    private float speed = 20;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;

    private void Start()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        //get input from user
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        //move forward 
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput );
        //turn func
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
