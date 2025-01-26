using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class bubbleFire : MonoBehaviour
{
    //public Transform startPos;
    public bool fired;
    public float firedTime;
    public GameObject bubblePrefab;
    public List<GameObject> bubbles;

    [SerializeField] private AudioClip clawSnap;
    [SerializeField] private AudioClip firstPop;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        fired = false;

        audioSource = GetComponent<AudioSource>();

        //transform.position = new Vector3(-1.0f, startPos.transform.position.y, startPos.transform.position.z);
        //transform.localEulerAngles = new Vector3(startPos.localEulerAngles.x, startPos.localEulerAngles.y, startPos.localEulerAngles.z - 90.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (!fired && Input.GetMouseButton(0))
        {
            fired = true;
            firedTime = Time.time;
            bubbles.Add(Instantiate(bubblePrefab, transform.position, transform.rotation));
            audioSource.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
            audioSource.PlayOneShot(clawSnap);
            audioSource.PlayOneShot(firstPop);

            //print(Math.Sin(Math.PI));
            //print(bubblePrefab.transform.localScale.y / 2);

        }

        if (Time.time > firedTime + 0.5f)
        {
            fired = false;
        }

        bubbles = bubbles.Where(bubble => bubble != null).ToList();

        for (int i = 0; i < bubbles.Count; i++)
        {
            //print(bubbles[i].transform.position.y);
            //print(bubbles[i].transform.localScale.y / 2 + 0.1f);
            if (bubbles[i].transform.position.y <= bubbles[i].transform.localScale.y / 2 + 0.1f)
            {
                //print("pop");
                Destroy(bubbles[i]);

            }
        }
    }
}
