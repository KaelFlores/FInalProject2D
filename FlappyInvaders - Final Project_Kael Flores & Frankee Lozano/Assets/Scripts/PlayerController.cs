using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2D;

    public float speed = 5.0f;
    public float min_Y, max_Y;

    public GameObject projectile;

    public Transform attack_Point;

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
        Attack();

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
        }
        else if (Input.GetAxis("Vertical") < 0f)
        {
            Vector3 temp = transform.position;

            temp.y -= speed * Time.deltaTime;

            transform.position = temp;
        }
<<<<<<< HEAD
    }
    public void PlaySound(AudioClip clip)
=======
    } 

    void Attack()
>>>>>>> 4c577b1c2a6d3291323e81fa53b977f72d0bd3af
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(projectile, attack_Point.position, Quaternion.identity);
        }
    }
}
