using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool SharedInstance;

    private List<GameObject> pooledEnemies;
    
    public GameObject enemyToPool;

    public int amountOfEnemiesToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledEnemies = new List<GameObject>();
        
        GameObject tmpEnemy;
        
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
