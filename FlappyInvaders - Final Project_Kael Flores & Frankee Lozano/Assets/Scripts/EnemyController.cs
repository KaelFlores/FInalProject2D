using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Animator animator;

    public float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        float randomPositionY = Random.Range(-4.0f, 4.0f);
        transform.position = new Vector3(30.0f, randomPositionY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        if(transform.position.x < -10.0f)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            gameObject.SetActive(false);
            animator.SetTrigger("Explosion");
        }
    }
}
