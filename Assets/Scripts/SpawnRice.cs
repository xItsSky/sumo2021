using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRice : MonoBehaviour
{
    public GameObject rice;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRiceEnum());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        Instantiate(rice, new Vector3(Random.Range(-11f, 11f), 24, -15), Quaternion.identity);
    }

    IEnumerator SpawnRiceEnum() {
        Spawn();

        yield return new WaitForSeconds(Random.Range(3, 8));

        StartCoroutine(SpawnRiceEnum());
    }
}
