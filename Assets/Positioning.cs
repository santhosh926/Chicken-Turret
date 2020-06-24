using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioning : MonoBehaviour
{
    public GameObject chicken;
    Rigidbody rb;

    void Start()
    {
        chicken.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        rb = chicken.GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(chicken, transform.position, transform.rotation);
    }
}
