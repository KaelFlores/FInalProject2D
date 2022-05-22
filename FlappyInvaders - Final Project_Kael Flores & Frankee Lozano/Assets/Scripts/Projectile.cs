using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_Timer = 3f;

    private float timeToDeactivate;
    // Start is called before the first frame update
    void OnEnable()
    {
        timeToDeactivate = deactivate_Timer;   
    }

    // Update is called once per frame
    void Update()
    {
        timeToDeactivate -= Time.deltaTime;
        transform.position += Vector3.right * speed * Time.deltaTime;
        if(transform.position.x > 25.0f || timeToDeactivate <= 0)
        {
            Destroy(gameObject);
        }
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
