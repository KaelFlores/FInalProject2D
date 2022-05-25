using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPool : MonoBehaviour
{
    public GameObject planetsPrefab;
    public int planetPoolSize = 5;
    public float spawnRate = 20f;
    public float planetMin = -1f;
    public float planetMax = 3.5f;
    private GameObject[] planet;
    private int currentplanet = 0;
    private Vector2 objectPoolPosition = new Vector2(25, -5);
    private float spawnXPosition = 50f;
    private float timeSinceLastSpawned;

    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawned = 0f;

        planet = new GameObject[planetPoolSize];

        for (int i = 0; i < planetPoolSize; i++)
        {
            planet[i] = (GameObject)Instantiate(planetsPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if(GameController.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            float spawnYPosition = Random.Range(planetMin, planetMax);

            planet[currentplanet].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            currentplanet++;

            if (currentplanet >= planetPoolSize)
            {
                currentplanet = 0;
            }
        }
    }
}
