using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public bool isGrounded = false;
    public bool isCollision = false;

    void Start()
    {

    }

    void Update()
    {

        Jump();

        Vector3 movement = new Vector3(0f, 0f, 0f);

        if (gameObject.name == "Sumo right")
        {
            movement = new Vector3(Input.GetAxis("Horizontal right"), 0f, 0f);
        }
        else if (gameObject.name == "Sumo left")
        {
            movement = new Vector3(Input.GetAxis("Horizontal left"), 0f, 0f);
        }

        transform.position += movement * Time.deltaTime * speed;

        Collision();

    }

    void Jump()
    {

        if (gameObject.name == "Sumo right")
        {
            if (Input.GetKeyDown("up") && isGrounded == true)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            }
        }
        else if (gameObject.name == "Sumo left")
        {
            if (Input.GetKeyDown("z") && isGrounded == true)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            }
        }

    }

    void Collision()
    {


    }

}
