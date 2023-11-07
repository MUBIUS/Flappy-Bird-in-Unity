using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate;
    private float timer;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        timer = UnityEngine.Random.Range(5, 8);
        spawnRate = UnityEngine.Random.Range(1, 5);
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Console.WriteLine("lowest Point:" + lowestPoint);
        Console.WriteLine("Heighest Point:" + heighestPoint);

        Instantiate(cloud, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, heighestPoint),0),transform.rotation);
    }
}
