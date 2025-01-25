using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleFire : MonoBehaviour
{
    public Transform startPos;
    public bool fired;
    // Start is called before the first frame update
    void Start()
    {
        fired = false;

        transform.position = new Vector3(-1.0f, startPos.transform.position.y, startPos.transform.position.z);
        transform.localEulerAngles = new Vector3(startPos.localEulerAngles.x, startPos.localEulerAngles.y, startPos.localEulerAngles.z - 90.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (!fired)
        {
            transform.localEulerAngles = new Vector3(startPos.localEulerAngles.x, startPos.localEulerAngles.y, startPos.localEulerAngles.z - 90.0f);
            transform.position = new Vector3(startPos.transform.position.x, startPos.transform.position.y, startPos.transform.position.z);
            transform.position += -transform.right;
        }
        
    }
}
