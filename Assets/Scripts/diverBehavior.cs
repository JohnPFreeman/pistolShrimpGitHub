using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class diverBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.5f;
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
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,2,0), speed * Time.deltaTime);
    }
}
