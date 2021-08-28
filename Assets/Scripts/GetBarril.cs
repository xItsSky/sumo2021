using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetBarril : MonoBehaviour
{
    bool stopCollide = false;

    public int countBarril = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countBarril > 2)
            SceneManager.LoadScene("Victoire");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "barril" && !stopCollide) {
            stopCollide = true;
            countBarril++;

            GameObject.Find("Main Camera").GetComponent<SpawnBarril>().moving = false;

            Destroy(collision.gameObject);

            stopCollide = false;
        }
            
    }
}
