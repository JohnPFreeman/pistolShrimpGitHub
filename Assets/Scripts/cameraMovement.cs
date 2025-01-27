using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, 1.0f, 0.0f);
        transform.localEulerAngles = new Vector3(0.0f, 90.0f, 90.0f);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles += new Vector3(0.0f, -50.0f * Time.deltaTime, 0.0f);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles += new Vector3(0.0f, 50.0f * Time.deltaTime, 0.0f);

        }

        if (Input.GetKey(KeyCode.W) && transform.localEulerAngles.z > 60)
        {
            transform.Rotate(0.0f, 0.0f, -25.0f * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S) && transform.localEulerAngles.z < 110)
        {
            transform.Rotate(0.0f, 0.0f, 25.0f * Time.deltaTime);

        }

    }
}
