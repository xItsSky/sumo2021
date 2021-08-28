using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float defaultForce = 0.1f;
    public float force;
    public bool isGrounded = false;
    public bool isCollision = false;
    private bool canMove = true;
    public bool facingRight;
    public Animator animator;
    public string axis;
    public bool hasBeanHit = false;

    void Start()
    {
        if (this.gameObject.name == "Sumo right")
            this.flip(-1);

        this.force = defaultForce;
    }

    void Update()
    {
        this.move();
        Collision();
        checkForce();
    }

    void move()
    {
        Vector3 movement = new Vector3(0f, 0f, 0f);

        float move = 0;
        if (gameObject.name == "Sumo right" && canMove)
        {
            move = Input.GetAxis("Horizontal right");
        }
        else if (gameObject.name == "Sumo left" && canMove)
        {
            move = Input.GetAxis("Horizontal left");
        }

        movement = new Vector3(move, 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        this.flip(move);
        this.anim(move);
        this.Jump();
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

        if (isCollision)
        {
            isCollision = false;
            canMove = false;

            if (gameObject.name == "Sumo right")
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * 5f, 0f), ForceMode2D.Impulse);
            }
            else if (gameObject.name == "Sumo left")
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * -5f, 0f), ForceMode2D.Impulse);
            }

            

            StartCoroutine(StopCollision());

        }


    }

    IEnumerator StopCollision()
    {
        yield return new WaitForSeconds(0.4f);
        canMove = true;

    }

    void anim(float move)
    {
        if (move != 0)
            this.animator.SetBool("isWalking", true);
        else
            this.animator.SetBool("isWalking", false);
    }

    void flip(float move)
    {
        if (move < 0)
        {
            this.facingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if(move > 0)
        {
            this.facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void checkForce()
    {
        if(this.hasBeanHit)
        {
            this.hasBeanHit = false;
            StartCoroutine(resetForce());
        }
    }

    public void setMove(bool value)
    {
        this.canMove = value;
    }

    public void setForce(float value)
    {
        this.hasBeanHit = true;
        this.force = value;
    }

    IEnumerator resetForce()
    {
        yield return new WaitForSecondsRealtime(0.30f);
        this.force = this.defaultForce;
        print("Force reset to " + this.force);
    }
}
