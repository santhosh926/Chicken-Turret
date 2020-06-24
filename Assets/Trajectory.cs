using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trajectory : MonoBehaviour
{

    Rigidbody rb;
    public GameObject go;

    // Start is called before the first frame update
    void Start()

    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(17 * transform.up, ForceMode.Impulse);
    }



    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void Awake()
    {

    }

}