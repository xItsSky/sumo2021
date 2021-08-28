using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Pause))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (Time.timeScale == 1)
            {
                this.PauseGame();

            }
            else
            {
                this.ResumeGame();

            }
        }
    }


    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
