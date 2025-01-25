using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localEulerAngles = new Vector3(0.0f, 0.0f, 90.0f);
        //self.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
