using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRice : MonoBehaviour
{
    private float sc;

    // Start is called before the first frame update
    void Start()
    {
        sc = gameObject.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "bol") {
            Destroy(collision.gameObject);

            sc += 0.2f;

            gameObject.transform.localScale = new Vector3(sc, sc, 1);
            gameObject.GetComponent<Rigidbody2D>().mass += 0.3f;

            StartCoroutine(ResetScale());
        }
    }

    IEnumerator ResetScale() {
        yield return new WaitForSeconds(2);

        sc -= 0.2f;
        gameObject.transform.localScale = new Vector3(sc, sc, 1);
        gameObject.GetComponent<Rigidbody2D>().mass -= 0.3f;
    }
}
