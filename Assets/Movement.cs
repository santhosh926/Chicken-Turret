using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 tiltPos;

    // Start is called before the first frame update
    void Start()
    {
        tiltPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        print(transform.rotation.x);
        if (Input.GetKey("left") && transform.rotation.x > -.207)
            transform.RotateAround(tiltPos, Vector3.left, 3 );

        if (Input.GetKey("right") && transform.rotation.x < -0.026)
            transform.RotateAround(tiltPos, Vector3.right, 3f);
    }
}
