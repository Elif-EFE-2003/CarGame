using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Variables
    private float speed=10.0f;
    private float turnSpeed=25.0f;
     private float horizontalInput;
     private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(0,0,1);
         
        //We move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed* horizontalInput);
        
    }
}
