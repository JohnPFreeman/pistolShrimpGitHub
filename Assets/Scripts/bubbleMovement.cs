using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleMovement : MonoBehaviour
{
    Rigidbody bubble;
    
    // Start is called before the first frame update
    void Start()
    {
        bubble = GetComponent<Rigidbody>();
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z); ;
        transform.position += transform.up * 1;

        bubble.velocity = transform.up * 100.0f;
        

    }

    // Update is called once per frame
    void Update()
    {
        //print(bubble.velocity.y);
        bubble.AddForce(new Vector3(0.0f, -2.0f, 0.0f));
    }
}
