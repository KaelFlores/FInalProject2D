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

    public float attack_Timer = 1f;
    private float current_Attack_Timer;
    private bool canAttack;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        current_Attack_Timer = attack_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Attack();
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

    void Attack()
    {
        attack_Timer += Time.deltaTime;
        if (attack_Timer > current_Attack_Timer)
        {
            canAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if(canAttack)
            {
                canAttack = false;
                attack_Timer = 0f;
                Instantiate(projectile, attack_Point.position, Quaternion.identity);
            }
        }
    }
}
