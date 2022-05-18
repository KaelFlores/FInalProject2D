using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject Enemy;
    float maxSpawnRateInSeconds = 5f;
    public float EnemyMin = -1f;
    public float EnemyMax = 5f;
    private Vector2 objectPoolPosition = new Vector2(27, 1);
    private float spawnXPosition = 10f;
    private int currentEnemy = 0;

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
        Instantiate(Enemy, objectPoolPosition, Quaternion.identity);

        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawninNSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {

            float spawnYPosition = Random.Range(EnemyMin, EnemyMax);

            Enemies[currentEnemy].transform.position = new Vector2(spawnXPosition, spawnYPosition);

        }
    }
}
