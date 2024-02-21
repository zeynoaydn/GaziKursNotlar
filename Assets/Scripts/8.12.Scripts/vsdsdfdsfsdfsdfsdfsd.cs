using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vsdsdfdsfsdfsdfsdfsd : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }


    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //kuvvet eklenecek
            //rb.AddForce(Vector3.forward * 250.0f, ForceMode.Force);
            rb.AddForce(new Vector3(10,0,100), ForceMode.Force);


        }
    }
}
