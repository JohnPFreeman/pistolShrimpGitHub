using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleMovement : MonoBehaviour
{
    Rigidbody bubble;

    [SerializeField] private AudioClip move1;
    [SerializeField] private AudioClip move2;
    [SerializeField] private AudioClip move3;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        bubble = GetComponent<Rigidbody>();
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z); ;
        transform.position += transform.up * 1;

        bubble.velocity = transform.up * 100.0f;

        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
        int rand = UnityEngine.Random.Range(0, 3);
        if (rand == 0)
        {
            audioSource.clip = move1;
        } else if (rand == 1)
        {
            audioSource.clip = move2;
        } else {
            audioSource.clip = move3;
        }

        audioSource.Play();
        



    }

    // Update is called once per frame
    void Update()
    {
        //print(bubble.velocity.y);
        bubble.AddForce(new Vector3(0.0f, -2.0f, 0.0f));
    }
}
