using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private Animator animator;
    public Move blueMovmentManager, redMovmentManager;
    public float force = 0.11f;

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
        if (Input.GetKeyDown(KeyCode.E) && this.gameObject.name == "Sumo left")
        {
            this.animator.Play("blue_hit");
            this.applyForce("blue");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && this.gameObject.name == "Sumo right")
        {
            this.animator.Play("red_hit");
            this.applyForce("red");
        }
    }

    void applyForce(string target)
    {
        if(target == "blue")
            this.redMovmentManager.setForce(this.force);
        else if(target == "red")
            this.blueMovmentManager.setForce(this.force);
    }

    public void setForce(float duree) {
        force += 0.3f;

        StartCoroutine(resetTiming(duree));
    }

    IEnumerator resetTiming(float duree) {
        yield return new WaitForSeconds(duree);
        force -= 0.3f;
    }
}
