using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
   

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
  //    speed = GameObject.FindGameObjectsWithTag("Pipe").GetComponent<PipeMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
       
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Console.WriteLine("lowest Point:" + lowestPoint);
        Console.WriteLine("Heighest Point:" + heighestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
