using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("SamScene");
    }
    public void Option()
    {

    }

    public void Back()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0) //On test si on est pas déjà dans le menu
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


    public void Exit()
    {
        Application.Quit();
    }


}
