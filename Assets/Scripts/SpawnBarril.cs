using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarril : MonoBehaviour {
    public GameObject barril;
    public GameObject barrilLTR;

    public bool moving = false;

    public int nb = -11;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(SpawnBarrilEnum());
    }

    // Update is called once per frame
    void Update() {
        if (moving) {
            if (nb == -11) {
                GameObject.FindGameObjectWithTag("barrilTR").transform.position = new Vector3(GameObject.FindGameObjectWithTag("barrilTR").transform.position.x + 6f * Time.deltaTime, GameObject.FindGameObjectWithTag("barrilTR").transform.position.y, GameObject.FindGameObjectWithTag("barrilTR").transform.position.z);
            } else {
                GameObject.FindGameObjectWithTag("barril").transform.position = new Vector3(GameObject.FindGameObjectWithTag("barril").transform.position.x - 6f * Time.deltaTime, GameObject.FindGameObjectWithTag("barril").transform.position.y, GameObject.FindGameObjectWithTag("barril").transform.position.z);
            }
        }
    }

    void Spawn() {
        int rand = Random.Range(0, 2);

        if (rand == 0)
            nb = -11;
        else
            nb = 12;

        if (nb == -11) {
            Instantiate(barrilLTR, new Vector3(nb, 24, -15), Quaternion.identity);
        } else {
            Instantiate(barril, new Vector3(nb, 24, -15), Quaternion.identity);
        }
        
    }

    IEnumerator SpawnBarrilEnum() {
        Spawn();

        yield return new WaitForSeconds(15);

        StartCoroutine(SpawnBarrilEnum());
    }
}
