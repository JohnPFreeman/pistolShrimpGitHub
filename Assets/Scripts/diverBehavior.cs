using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class diverBehavior : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject shrimp;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("object has entered");
        if (other.gameObject.CompareTag("bubble"))
        {
            print("bubble found"); 
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, 0), speed * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x, 1.435203f, transform.position.z);
        transform.LookAt(new Vector3(0.0f, transform.position.y, 0.0f));
    }
}
