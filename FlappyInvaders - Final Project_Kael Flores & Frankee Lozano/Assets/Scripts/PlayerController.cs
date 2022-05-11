using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2D;

    public float speed = 5.0f;
    public float min_Y, max_Y;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.C))
        {

        }
    }

    void MovePlayer()
    {
        if (Input.GetAxis("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if (temp.y > max_Y)
                temp.y = max_Y;

            transform.position = temp;
        } else if (Input.GetAxis("Vertical") < 0f)
        {
            Vector3 temp = transform.position;

            temp.y -= speed * Time.deltaTime;

            transform.position = temp;
        }
    } 
}
