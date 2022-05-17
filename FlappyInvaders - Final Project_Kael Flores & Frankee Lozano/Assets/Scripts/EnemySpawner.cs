using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemies;
    float maxSpawnRateInSeconds = 5f;
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Instantiate(Enemies, spawnpoint.position, Quaternion.identity);

        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawninNSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            spawninNSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawninNSeconds = 1f;
        Invoke("SpawnEnemy", spawninNSeconds);
    }
}
