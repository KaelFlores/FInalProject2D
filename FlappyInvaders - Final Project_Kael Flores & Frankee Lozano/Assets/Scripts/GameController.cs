using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timeUntilEnemy = 1.0f;
    public float minuntilEnemy = 0.25f;
    public float maxUntilEnemy = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilEnemy -= Time.deltaTime;

        if(timeUntilEnemy <= 0)
        {
            GameObject enemy = ObjectPool.SharedInstance.GetPooledEnemy();
            if(enemy != null)
            {
                enemy.SetActive(true);
            }
            timeUntilEnemy = Random.Range(minuntilEnemy, maxUntilEnemy);
        }
    }
}
