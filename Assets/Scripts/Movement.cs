using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotateTrust = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()

    {

       
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
           
        }
    }

    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotateTrust * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.freezeRotation = true;
            transform.Rotate(-Vector3.forward * rotateTrust * Time.deltaTime); 
        }
    }
}
