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
<<<<<<< HEAD
<<<<<<< HEAD

    AudioSource audioSource;
    public AudioClip whoosh;
=======
>>>>>>> parent of 77aafcb (Shooting)
=======
>>>>>>> parent of 77aafcb (Shooting)

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
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
        }
        else if (Input.GetAxis("Vertical") < 0f)
        {
            Vector3 temp = transform.position;

            temp.y -= speed * Time.deltaTime;

            transform.position = temp;
        }
<<<<<<< HEAD
<<<<<<< HEAD
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
=======
    } 
>>>>>>> parent of 77aafcb (Shooting)
=======
    } 
>>>>>>> parent of 77aafcb (Shooting)
}
