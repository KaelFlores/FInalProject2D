using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2D;

    float vertical;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        Vector2 position = rb2D.position;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rb2D.MovePosition(position);
    }
}
