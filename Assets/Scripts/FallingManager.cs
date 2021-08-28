using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{
    private string[] players = { "Sumo left", "Sumo right" };
    private bool[] playersStatus = { false, false };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playersStatus[0] == true)
        {
            // Do somethings
        }
        else if (playersStatus[1] == true)
        {
            // Do somethings else
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionWith = collision.gameObject;
        print("Collide !");
        if(this.contains(name)) {
            playersStatus[this.indexOf(name)] = true;
            Destroy(gameObject);
            print("destroy !");
        }
    }

    private bool contains(string name)
    {
        for(int i = 0; i < this.players.Length; i++)
        {
            if (players[i].Equals(name))
                return true;
        }
        return false;
    }

    private int indexOf(string name)
    {
        for (int i = 0; i < this.players.Length; i++)
        {
            if (players[i].Equals(name))
                return i;
        }
        return -1;
    }
}
