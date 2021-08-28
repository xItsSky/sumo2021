using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Sumo;
    // Start is called before the first frame update
    void Start()
    {
        Sumo = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Ground" || collision.collider.tag == "Sumo")
        {

            if (collision.collider.tag == "Sumo")
            {
                Sumo.GetComponent<Move>().isCollision = true;
            }
            else
            {
                Sumo.GetComponent<Move>().isGrounded = true;
            }

            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Ground" || collision.collider.tag == "Sumo")
        {

            if(collision.collider.tag == "Sumo")
            {
                Sumo.GetComponent<Move>().isCollision = false;
            }
            else
            {
                Sumo.GetComponent<Move>().isGrounded = false;
            }

        }
    }
}
