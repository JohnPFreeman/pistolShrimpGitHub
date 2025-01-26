using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveBehavior : MonoBehaviour
{
    public float spawnedTime;
    public float spawnRate;
    public float theta;
    public float r;
    public GameObject diverPrefab;
    public List<GameObject> divers;

    // Start is called before the first frame update
    void Start()
    {
        spawnedTime = 0.0f;
        spawnRate = 8.0f;


    }

    // Update is called once per frame
    void Update()
    {
        if (spawnedTime + spawnRate < Time.time)
        {
            spawnedTime = Time.time;
            theta = UnityEngine.Random.Range(0, 2*Mathf.PI);
            r = UnityEngine.Random.Range(50, 75);
            if (spawnRate > 0.1f)
            {
                spawnRate *= 0.975f;
            }
            
            print(spawnRate);
            divers.Add(Instantiate(diverPrefab, new Vector3(r*MathF.Cos(theta), 0.6553028f, r * MathF.Sin(theta)), new Quaternion(0, 0, 0, 0)));
        }
    }
}
