using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float timeUntilEnemy = 1.0f;
    public float minuntilEnemy = 0.25f;
    public float maxUntilEnemy = 2.0f;
    public static GameController instance;

    public float scrollSpeed = -1.25f;
    private int score = 0;
    public bool gameOver = false;
    public Text scoreText;
    public GameObject gameOvertext;

    //Awake is called when game start up or "wakes up"
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
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

        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ShipGetsPoints()
    {
        if (gameOver)
            return;
        score++;
        scoreText.text = "Planets Passed: " + score.ToString();
    }

    public void ShipCrash()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}
