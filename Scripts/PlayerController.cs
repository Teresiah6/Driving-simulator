using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
    
{
    //changed to private and cannot be change in the playercontroller component
    private float horizontalInput;
    private float forwardInput;
    private float speed = 20.0f;
    private float turnSpeed =45.0f;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);
        //rotates car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
