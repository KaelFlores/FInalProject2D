using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool SharedInstance;

    private List<GameObject> pooledEnemies;
    private List<GameObject> pooledBlasters;
    private List<GameObject> pooledCrossBlasts;
    private List<GameObject> pooledSparkBlasts;
    public GameObject enemyToPool;
    public GameObject blasterToPool;
    public GameObject crossBlastToPool;
    public GameObject sparkBlastToPool;
    public int amountOfEnemiesToPool;
    public int amountOfBlastersToPool;
    public int amountOfCrossBlastsToPool;
    public int amountOfSparkBlastsToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledEnemies = new List<GameObject>();
        pooledBlasters = new List<GameObject>();
        pooledCrossBlasts = new List<GameObject>();
        pooledSparkBlasts = new List<GameObject>();
        GameObject tmpEnemy;
        GameObject tmpBlaster;
        GameObject tmpCrossBlast;
        GameObject tmpSparkBlast;
        for (int i = 0; i < amountOfEnemiesToPool; i++)
        {
            tmpEnemy = Instantiate(enemyToPool);
            tmpEnemy.SetActive(false);
            pooledEnemies.Add(tmpEnemy);
        }
    }

    public GameObject GetPooledEnemy()
    {
        for (int i = 0; i < amountOfEnemiesToPool; i++)
        {
            if (pooledEnemies[i].activeInHierarchy == false)
            {
                return pooledEnemies[i];
            }
        }
        return null;
    }

}
