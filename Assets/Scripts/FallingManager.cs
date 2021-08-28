using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FallingManager : MonoBehaviour
{
    public Move movmentManagerRed, movmentManagerBlue;
    public Text message;
    public Text red_score;
    public Text blue_score;
    private string[] players = { "Sumo left", "Sumo right" };
    public Vector3 position_blue, position_red;
    private bool[] playersStatus = { false, false };
    private float red_scoring = 0f;
    private float blue_scoring = 0f;

    // Start is called before the first frame update
    void Start()
    {
        byte[] bytes_blue = System.Text.Encoding.Default.GetBytes("" + blue_scoring);
        this.blue_score.text = System.Text.Encoding.UTF8.GetString(bytes_blue);

        byte[] bytes_red = System.Text.Encoding.Default.GetBytes("" + red_scoring);
        this.red_score.text = System.Text.Encoding.UTF8.GetString(bytes_red);
    }

    // Update is called once per frame
    void Update()
    {
        // blue
        if (playersStatus[0] == true)
        {

            if(red_scoring != 2)
            {
                red_scoring++;
                byte[] bytes_red = System.Text.Encoding.Default.GetBytes("" + red_scoring);
                this.red_score.text = System.Text.Encoding.UTF8.GetString(bytes_red);

                playersStatus[0] = false;


            }
            else
            {

                red_scoring++;
                byte[] bytes_red = System.Text.Encoding.Default.GetBytes("" + red_scoring);
                this.red_score.text = System.Text.Encoding.UTF8.GetString(bytes_red);

                playersStatus[0] = false;

                this.movmentManagerRed.setMove(false);

                SceneManager.LoadScene("Victoire");

            }


        }
        // red
        else if (playersStatus[1] == true)
        {

            if (blue_scoring != 2)
            {
                blue_scoring++;
                byte[] bytes_blue = System.Text.Encoding.Default.GetBytes("" + blue_scoring);
                this.blue_score.text = System.Text.Encoding.UTF8.GetString(bytes_blue);

                playersStatus[1] = false;


            }
            else
            {

                blue_scoring++;
                byte[] bytes_blue = System.Text.Encoding.Default.GetBytes("" + blue_scoring);
                this.blue_score.text = System.Text.Encoding.UTF8.GetString(bytes_blue);

                playersStatus[1] = false;

                this.movmentManagerBlue.setMove(false);

                SceneManager.LoadScene("Victoire");
            }


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionWith = collision.gameObject;
        print("Collide with " + collisionWith.name);



        if (this.contains(collisionWith.name)) {

            int index = this.indexOf(collisionWith.name);

            playersStatus[index] = true;

            if(index == 0)
            {
                
                collisionWith.transform.position = position_blue;
                print(collisionWith.transform.position);
            }
            else if(index == 1)
            {
                collisionWith.transform.position = position_red;

            }


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
