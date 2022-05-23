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

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        if(transform.position.x < -10.0f)
        {
            float randomPositionY = Random.Range(-5.0f, 5.0f);
            transform.position = new Vector3(30.0f, randomPositionY, 0);

            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            gameObject.SetActive(false);
            animator.SetTrigger("Explosion");
            transform.position = new Vector3(30.0f, 0);
        }
    }
}
