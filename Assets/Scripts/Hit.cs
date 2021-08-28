using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.hit();
    }



    void hit()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.animator.Play("blue_hit");
        }
    }
}
