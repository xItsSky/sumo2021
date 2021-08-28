using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public bool facingRight;
    public bool isGrounded = false;
    public Animator animator;

    void Start(){
    }

    void Update()
    {

        this.Jump();
        this.flip(Input.GetAxis("Horizontal"));
        this.anim(Input.GetAxis("Horizontal"));
        this.move(Input.GetAxis("Horizontal"));

    }

    void move(float move)
    {
        Vector3 movement = new Vector3(move, 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {
        if(Input.GetKeyDown("space") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
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
}
