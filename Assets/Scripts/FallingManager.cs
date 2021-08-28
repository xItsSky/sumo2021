using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingManager : MonoBehaviour
{
    public Move movmentManagerRed, movmentManagerBlue;
    public Text message;
    private string[] players = { "Sumo left", "Sumo right" };
    private bool[] playersStatus = { false, false };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // blue
        if (playersStatus[0] == true)
        {
            this.movmentManagerRed.setMove(false);
            byte[] bytes = System.Text.Encoding.Default.GetBytes("Le joueur rouge a gagne !");
            this.message.text = System.Text.Encoding.UTF8.GetString(bytes);
        }
        // red
        else if (playersStatus[1] == true)
        {
            this.movmentManagerBlue.setMove(false);
            byte[] bytes = System.Text.Encoding.Default.GetBytes("Le joueur bleu a gagne !");
            this.message.text = System.Text.Encoding.UTF8.GetString(bytes);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionWith = collision.gameObject;
        print("Collide with " + collisionWith.name);
        if (this.contains(collisionWith.name)) {
            playersStatus[this.indexOf(collisionWith.name)] = true;
            Destroy(collisionWith);
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
