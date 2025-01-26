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
    public GameObject RightClawOpen;
    public GameObject RightClawClosed;
    public List<GameObject> bubbles;

    // Start is called before the first frame update
    void Start()
    {
        fired = false;
        RightClawClosed.SetActive(false);
        RightClawOpen.SetActive(true);

        //transform.position = new Vector3(-1.0f, startPos.transform.position.y, startPos.transform.position.z);
        //transform.localEulerAngles = new Vector3(startPos.localEulerAngles.x, startPos.localEulerAngles.y, startPos.localEulerAngles.z - 90.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (!fired && Input.GetMouseButton(0))
        {
            fired = true;
            // Change claw image
            RightClawClosed.SetActive(true);
            RightClawOpen.SetActive(false);
            firedTime = Time.time;
            bubbles.Add(Instantiate(bubblePrefab, transform.position, transform.rotation));

            //print(Math.Sin(Math.PI));
            //print(bubblePrefab.transform.localScale.y / 2);

        }

        if (Time.time > firedTime + 0.5f)
        {
            fired = false;
            // Change claw image
            RightClawClosed.SetActive(false);
            RightClawOpen.SetActive(true);
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
