using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{ 
    public float minWait;
    public float maxWait;

    private bool isSpawning;

    void Awake()
        {
            isSpawning = false;
        }

    void Update()
        {
        if (!isSpawning)
            {
            float timer = Random.Range(minWait, maxWait);
            Invoke("SpawnObject", timer);
            isSpawning = true;
            }
        }

    void SpawnObject()
        {
        isSpawning = false;
        }
   
}
